using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Security;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Xerox
{
    public partial class Form1 : Form
    {
        private IList<Task> Tasks { get; } = new List<Task>();
        private IList<(Label fileName, ProgressBar bar, Label copied)> ProgressBars { get; set; }
        private string From { get; set; } = ""; //папка, из которой копируем
        private string To { get; set; } = ""; //папка, в которую копируем
        private BlockingCollection<(string from, string to, long copied, long size)> FilesQueue { get; set; }
        private IList<(string from, string to, long copied, long size)> Files { get; set; } =
            new List<(string, string, long, long)>();
        private long TotalSize { get; set; } = 0; //общий размер всех файлов
        private long TotalCopied { get; set; } = 0; //общий размер скопированных на данных момент файлов
        public Form1()
        {
            InitializeComponent();
            ProgressBars = new List<(Label, ProgressBar, Label)> {
                (labelFile1, progressBar1, labelCopied1), 
                (labelFile2, progressBar2, labelCopied2), 
                (labelFile3, progressBar3, labelCopied3), 
                (labelFile4, progressBar4, labelCopied4), 
            };
        }
        private void Form1_Load(object sender, EventArgs e) => ShowBars(false);
                                                               
        private void buttonFrom_Click(object sender, EventArgs e) => 
            From = GetSelectedPath(textBoxFrom);

        private void buttonTo_Click(object sender, EventArgs e) =>
            To = GetSelectedPath(textBoxTo);

        private void buttonCopy_Click(object sender, EventArgs e)
        {
            From = textBoxFrom.Text;
            To = textBoxTo.Text;
            if (From.Length == 0 || To.Length == 0)
            {
                MessageBox.Show("Выберите пути копирования", "Ошибка!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ShowBars(true);
            Files.Clear();
            TotalCopied = TotalSize = 0;

            try
            {
                FillFiles(From, To);
                foreach (var bar in ProgressBars)
                    Tasks.Add(Task.Run(() => Copy(bar)));

                Task.WhenAll(Tasks)
                    .ContinueWith(t => {
                        ValueInvoke(progressBar, (int)(TotalCopied * 100 / TotalSize));
                        TextInvoke(labelTotal, $"{progressBar.Value} %");
                    })
                    .ContinueWith(t => Thread.Sleep(500))
                    .ContinueWith(
                        p => MessageBox.Show("Копирование завершено!", "Info",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
                    );
            }
            catch (Exception ex) when (
                ex is IOException || 
                ex is UnauthorizedAccessException ||
                ex is ArgumentException ||
                ex is ArgumentNullException ||
                ex is ArgumentOutOfRangeException ||
                ex is PathTooLongException ||
                ex is DirectoryNotFoundException ||
                ex is SecurityException ||
                ex is NotSupportedException ||
                ex is FileNotFoundException ||
                ex is OutOfMemoryException ||
                ex is ObjectDisposedException ||
                ex is InvalidEnumArgumentException ||
                ex is InvalidOperationException ||
                ex is OverflowException
            )
            {
                MessageBox.Show("Ошибка копирования!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                if(Directory.Exists(To))
                    Directory.Delete(To, recursive: true);
            }
        }
        private void ShowBars(bool state)
        {
            foreach (var bar in ProgressBars)
                bar.fileName.Visible = 
                bar.bar.Visible = 
                bar.copied.Visible = state;
            progressBar.Visible = state;
        }
        private string GetSelectedPath(TextBox box)
        {
            box.Text = "";
            FolderBrowserDialog folder = new FolderBrowserDialog();
            if (folder.ShowDialog() == DialogResult.Cancel)
                return "";
            box.Text = folder.SelectedPath;
            return folder.SelectedPath;
        }

        private void FillFiles(string from, string to)
        {
            foreach (string file in Directory.GetFiles(from))
            {
                string name = Path.GetFileName(file);
                int size = (int)new FileInfo(file).Length;

                TotalSize += size; //собираем размер всех файлов
                Files.Add((file, Path.Combine(to, name), 0/*copied*/, size));
            }

            foreach (string dir in Directory.GetDirectories(from))
            {
                string newDir = Path.Combine(to, Path.GetFileName(dir));
                FillFiles(dir, newDir);
                Directory.CreateDirectory(newDir);
            }

            FilesQueue = new BlockingCollection<(string, string, long, long)>(
                new ConcurrentQueue<(string, string, long, long)>(Files));
        }
        private void Copy((Label fileName, ProgressBar bar, Label copied) bar)
        {
            while (FilesQueue.TryTake(out var file))
            {
                string fileFrom = Path.GetFileName(file.from);
                lock(Files)
                    TextInvoke(bar.fileName, fileFrom);

                byte[] buffer = new byte[4096];
                using (FileStream to = File.Create(file.to))
                    using (FileStream from = File.OpenRead(file.from))
                        while (true) //бежим по файлу пока не закончится
                        {
                            int read = from.Read(buffer, 0, buffer.Length);
                            if (read == 0)
                                break;
                            to.Write(buffer, 0, read);
                            file.copied += read;

                            int copiedValue = (int)(file.copied * 100 / file.size);
                            string copiedText = $"{file.copied / 1000} / {file.size / 1000} Kb";
                            int totalValue = (int)(TotalCopied * 100 / TotalSize);
                            lock (Files)
                            {
                                TotalCopied += read;

                                ValueInvoke(bar.bar, copiedValue);
                                TextInvoke(bar.copied, copiedText);
                                ValueInvoke(progressBar, totalValue);
                                TextInvoke(labelTotal, $"{totalValue.ToString()} %");    
                            }
                        }
            }
        }
        private void ValueInvoke(ProgressBar bar, int value) =>
            bar.Invoke((Action)(() => bar.Value = value));
        private void TextInvoke(Label label, string text) => 
            label.Invoke((Action)(() => label.Text = text));
    }
}

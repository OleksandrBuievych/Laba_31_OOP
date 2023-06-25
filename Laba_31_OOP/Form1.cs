using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace Laba_31_OOP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
    }

        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshProcessList();
        }

        private void RefreshProcessList()
        {
            processListView.Items.Clear();
            Process[] processes = Process.GetProcesses();
            foreach (Process process in processes)
            {
                ListViewItem item = new ListViewItem(process.Id.ToString());
                item.SubItems.Add(process.ProcessName);
                item.SubItems.Add(process.MainWindowTitle);
                processListView.Items.Add(item);
            }
        }

        private void infoBtn_Click(object sender, EventArgs e)
        {
            if (processListView.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = processListView.SelectedItems[0];
                int processId = int.Parse(selectedItem.Text);
                Process process = Process.GetProcessById(processId);
                MessageBox.Show($"Інформація про процес:\n\nID: {process.Id}\nНазва: {process.ProcessName}\nЗаголовок: {process.MainWindowTitle}");
            }
        }

        private void stopBtn_Click(object sender, EventArgs e)
        {
            if (processListView.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = processListView.SelectedItems[0];
                int processId = int.Parse(selectedItem.Text);
                Process process = Process.GetProcessById(processId);
                process.Kill();
                RefreshProcessList();
            }
        }

        private void exportBtn_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Текстові файли (*.txt)|*.txt";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
                {
                    foreach (ListViewItem item in processListView.Items)
                    {
                        writer.WriteLine($"ID: {item.SubItems[0].Text}, Назва: {item.SubItems[1].Text}, Заголовок: {item.SubItems[2].Text}");
                    }
                }
            }
        }

        private void threadBtn_Click(object sender, EventArgs e)
        {
            if (processListView.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = processListView.SelectedItems[0];
                int processId = int.Parse(selectedItem.Text);
                Process process = Process.GetProcessById(processId);

                string threadsInfo = "Потоки процесу:\n\n";
                foreach (ProcessThread thread in process.Threads)
                {
                    threadsInfo += $"ID: {thread.Id}, Стан: {thread.ThreadState}\n";
                }

                MessageBox.Show(threadsInfo);
            }
        }

        private void modylesBtn_Click(object sender, EventArgs e)
        {
            if (processListView.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = processListView.SelectedItems[0];
                int processId = int.Parse(selectedItem.Text);
                Process process = Process.GetProcessById(processId);

                string modulesInfo = "Модулі процесу:\n\n";
                foreach (ProcessModule module in process.Modules)
                {
                    modulesInfo += $"Назва: {module.ModuleName}, Версія: {module.FileVersionInfo.FileVersion}\n";
                }

                MessageBox.Show(modulesInfo);
            }
        }

        private void addProcessButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Process.Start(openFileDialog.FileName);
                RefreshProcessList();
            }
        }
    }
}

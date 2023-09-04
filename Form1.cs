using System;
using System.IO;
using System.Windows.Forms;
using FFMpegCore;
using FFMpegCore.Enums;

namespace AVCHDをmp4にするやつ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Input_folder_pick_button_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "入力元のフォルダを選択してください";
            dialog.SelectedPath = Input_folder_path.Text;
            dialog.ShowNewFolderButton = false;
            if (dialog.ShowDialog(this) == DialogResult.OK)
            {
                Input_folder_path.Text = dialog.SelectedPath;
            }
        }

        private void Output_folder_pick_button_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog= new FolderBrowserDialog();
            dialog.Description = "出力先のフォルダを選択してください";
            dialog.SelectedPath= Output_folder_path.Text;
            if (dialog.ShowDialog(this) == DialogResult.OK)
            {
                Output_folder_path.Text = dialog.SelectedPath;
            }
        }

        private void Start_button_Click(object sender, EventArgs e)
        {
            Input_folder_pick_button.Enabled = false;
            Output_folder_pick_button.Enabled= false;
            Start_button.Enabled = false;
            Delete_check.Enabled = false;
            string[] files = Directory.GetFiles(Input_folder_path.Text,"*.MTS");
            foreach (string file in files)
            {
                Console.WriteLine(file);
                Console.WriteLine(Output_folder_path.Text + "\\" + Path.GetFileName(file) + ".mp4");
                FFMpegArguments.FromFileInput(file).OutputToFile(Output_folder_path.Text + "\\" + Path.GetFileName(file) + ".mp4", false, options => options.WithVideoCodec(VideoCodec.LibX264).WithAudioCodec(AudioCodec.Aac).WithFastStart()).ProcessSynchronously();

                if (Delete_check.Checked)
                {
                    File.Delete(file);
                }
            }
            Input_folder_pick_button.Enabled = true;
            Output_folder_pick_button.Enabled = true;
            Start_button.Enabled = true;
            Delete_check.Enabled = true;
        }
    }
}

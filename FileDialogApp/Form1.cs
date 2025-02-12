using System;
using System.Windows.Forms;

namespace FileDialogApp
{
    public class MainForm : Form
    {
        private Button btnOpenFile;
        private Label lblFilePath;

        public MainForm()
        {
            btnOpenFile = new Button { Text = "Select File", Location = new System.Drawing.Point(20, 20) };
            lblFilePath = new Label { Location = new System.Drawing.Point(20, 60), AutoSize = true };

            btnOpenFile.Click += BtnOpenFile_Click;

            Controls.Add(btnOpenFile);
            Controls.Add(lblFilePath);

            Text = "File Dialog Example";
            Size = new System.Drawing.Size(400, 150);
        }

        private void BtnOpenFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    lblFilePath.Text = "Selected File: " + openFileDialog.FileName;
                }
            }
        }
    }
}

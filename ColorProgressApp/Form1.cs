using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorProgressApp
{
    public class MainForm : Form
    {
        private ComboBox colorComboBox;
        private ProgressBar progressBar;
        private Button startButton;

        public MainForm()
        {
            // Set Form Properties
            Text = "Color & ProgressBar Demo";
            Size = new Size(400, 200);
            StartPosition = FormStartPosition.CenterScreen;

            // Create ComboBox
            colorComboBox = new ComboBox
            {
                Location = new Point(20, 20),
                Width = 150,
            };
            colorComboBox.Items.AddRange(new string[] { "Red", "Green", "Blue", "Yellow" });
            colorComboBox.SelectedIndexChanged += ColorComboBox_SelectedIndexChanged;

            // Create ProgressBar
            progressBar = new ProgressBar
            {
                Location = new Point(20, 60),
                Width = 300,
                Height = 20,
                Minimum = 0,
                Maximum = 100,
                Value = 0
            };

            // Create Start Button
            startButton = new Button
            {
                Text = "Start Progress",
                Location = new Point(20, 100),
                Width = 150
            };
            startButton.Click += StartButton_Click;

            // Add Controls to Form
            Controls.Add(colorComboBox);
            Controls.Add(progressBar);
            Controls.Add(startButton);
        }

        private async void StartButton_Click(object sender, EventArgs e)
        {
            // Simulate Progress
            progressBar.Value = 0;
            for (int i = 0; i <= 100; i += 10)
            {
                await Task.Delay(200); // Simulate work
                progressBar.Value = i;
            }
        }

        private void ColorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedColor = colorComboBox.SelectedItem.ToString();
            switch (selectedColor)
            {
                case "Red":
                    BackColor = Color.Red;
                    break;
                case "Green":
                    BackColor = Color.Green;
                    break;
                case "Blue":
                    BackColor = Color.Blue;
                    break;
                case "Yellow":
                    BackColor = Color.Yellow;
                    break;
            }
        }
    }
}

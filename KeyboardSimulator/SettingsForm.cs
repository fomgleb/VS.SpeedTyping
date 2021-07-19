using System;
using System.Windows.Forms;

namespace KeyboardSimulator
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();

            textBox.Text = Properties.Settings.Default.PrintableText;
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.PrintableText = textBox.Text;
            Properties.Settings.Default.Save();

            Close();
        }
    }
}

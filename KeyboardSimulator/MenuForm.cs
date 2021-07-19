using System;
using System.Windows.Forms;

namespace KeyboardSimulator
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            StartForm startForm = new StartForm();
            startForm.ShowDialog();
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            SettingsForm settingsForm = new SettingsForm();
            settingsForm.ShowDialog();
        }

        private void StatisticButton_Click(object sender, EventArgs e)
        {
            StatisticForm statisticForm = new StatisticForm();
            statisticForm.ShowDialog();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

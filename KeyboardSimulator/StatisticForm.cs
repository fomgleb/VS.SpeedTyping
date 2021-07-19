using System;
using System.Windows.Forms;

namespace KeyboardSimulator
{
    public partial class StatisticForm : Form
    {
        public StatisticForm()
        {
            InitializeComponent();

            int allSeconds = Properties.Settings.Default.AllSeconds;
            var timeSpan = TimeSpan.FromSeconds(allSeconds);

            symbolsLabel.Text = Properties.Settings.Default.AllSymbols.ToString();
            mistakesLabel.Text = Properties.Settings.Default.AllMistakes.ToString();
            accuracyLabel.Text = Convert.ToInt32((Convert.ToDouble(symbolsLabel.Text) - Convert.ToDouble(mistakesLabel.Text)) * 100.0 / Convert.ToDouble(symbolsLabel.Text)).ToString() + "%";
            if (allSeconds != 0)
                symbolsInMinuteLabel.Text = Convert.ToInt32(Convert.ToDouble(symbolsLabel.Text) / ((allSeconds * 100.0 / 60.0) / 100.0)).ToString();
            if (timeSpan.Seconds != 0)
            {
                timeLabel.Text += $"{timeSpan.Hours} h. ";
                timeLabel.Text += $"{timeSpan.Minutes} m. ";
                timeLabel.Text += $"{timeSpan.Seconds} sec.";
            }
        }
    }
}

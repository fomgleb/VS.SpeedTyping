using System;
using System.Drawing;
using System.Windows.Forms;

namespace KeyboardSimulator
{
    public partial class StartForm : Form
    {
        int secondsPassed;
        public StartForm()
        {
            InitializeComponent();

            printableTextBox.Text = Properties.Settings.Default.PrintableText;
            ActiveControl = toPrintTextBox;
        }

        private void toPrintTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (toPrintTextBox.Text == printableTextBox.Text)
            {
                Properties.Settings.Default.AllSymbols += Convert.ToInt32(symbolsLabel.Text);
                Properties.Settings.Default.AllMistakes += Convert.ToInt32(mistakesLabel.Text);
                Properties.Settings.Default.AllSeconds += secondsPassed;

                Properties.Settings.Default.Save();

                toPrintTextBox.Enabled = false;
                printableTextBox.ForeColor = Color.Green;
                timer1.Stop();
            }
            else
            {
                if (toPrintTextBox.Text.Length < printableTextBox.Text.Length && toPrintTextBox.Enabled == true && toPrintTextBox.Text == printableTextBox.Text.Remove(toPrintTextBox.Text.Length))
                    printableTextBox.ForeColor = Color.Black;
                else
                    printableTextBox.ForeColor = Color.Red;

                if (timer1.Enabled == false && toPrintTextBox.Enabled == true && pauseButton.Text != "Continue")
                    timer1.Enabled = true;

                symbolsLabel.Text = Convert.ToString(toPrintTextBox.Text.Length); // введенное количество символов

                if (e.KeyCode != Keys.Back && toPrintTextBox.Text != printableTextBox.Text) // количество ошибок
                {
                    if (toPrintTextBox.Text.Length > printableTextBox.Text.Length)
                        mistakesLabel.Text = Convert.ToString(Convert.ToInt32(mistakesLabel.Text) + 1);
                    else if (toPrintTextBox.Text.Length - 1 >= 0 && toPrintTextBox.Text[toPrintTextBox.Text.Length - 1] != printableTextBox.Text[toPrintTextBox.Text.Length - 1])
                        mistakesLabel.Text = Convert.ToString(Convert.ToInt32(mistakesLabel.Text) + 1);
                }

                try // точность в процентах
                {
                    accuracyLabel.Text = Convert.ToInt32((Convert.ToDouble(symbolsLabel.Text) - Convert.ToDouble(mistakesLabel.Text)) * 100.0 / Convert.ToDouble(symbolsLabel.Text)).ToString() + "%";
                }
                catch
                {
                }


                //if (toPrintTextBox.Text.Length > printableTextBox.Text.Length ||
                //    toPrintTextBox.Text.Length - 1 >= 0 &&
                //    e.KeyCode != Keys.Back &&
                //    toPrintTextBox.Text[toPrintTextBox.Text.Length - 1] != printableTextBox.Text[toPrintTextBox.Text.Length - 1])
                //    mistakesLabel.Text = Convert.ToString(Convert.ToInt32(mistakesLabel.Text) + 1);
            }

            progressLabel.Text = Convert.ToInt32(Convert.ToDouble(toPrintTextBox.Text.Length) * 100.0 / Convert.ToDouble(printableTextBox.Text.Length)).ToString() + "%";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            secondsPassed++;

            int seconds = secondsPassed;
            int minutes = 0;
            string time;

            while (seconds >= 60)
            {
                minutes += 1;
                seconds -= 60;
            }

            if (minutes < 10)
                time = $"0{minutes}:";
            else
                time = $"{minutes}:";

            if (seconds < 10)
                time += $"0{seconds}";
            else
                time += $"{seconds}";

            timeLabel.Text = time;

            if (secondsPassed != 0)
                symbolsInMinuteLabel.Text = Convert.ToInt32(Convert.ToDouble(symbolsLabel.Text) / ((secondsPassed * 100.0 / 60.0) / 100.0)).ToString();
        }

        private void pauseButton_Click(object sender, EventArgs e)
        {
            if (pauseButton.Text == "Pause")
            {
                timer1.Stop();
                timeLabel.ForeColor = Color.Yellow;
                pauseButton.Text = "Continue";
                toPrintTextBox.Enabled = false;
            }
            else if (pauseButton.Text == "Continue")
            {
                timer1.Start();
                timeLabel.ForeColor = Color.Black;
                pauseButton.Text = "Pause";
                toPrintTextBox.Enabled = true;
                ActiveControl = toPrintTextBox;
            }
        }
    }
}

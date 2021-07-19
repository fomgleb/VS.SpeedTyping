namespace KeyboardSimulator
{
    partial class StartForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.progressLabel = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.accuracyLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.mistakesLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.symbolsLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.symbolsInMinuteLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.printableTextBox = new System.Windows.Forms.RichTextBox();
            this.toPrintTextBox = new System.Windows.Forms.RichTextBox();
            this.pauseButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.13953F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.86047F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(947, 575);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.Controls.Add(this.label4, 0, 5);
            this.tableLayoutPanel3.Controls.Add(this.progressLabel, 0, 5);
            this.tableLayoutPanel3.Controls.Add(this.timeLabel, 1, 4);
            this.tableLayoutPanel3.Controls.Add(this.label9, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.accuracyLabel, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.label7, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.mistakesLabel, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.symbolsLabel, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.symbolsInMinuteLabel, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tableLayoutPanel3.Location = new System.Drawing.Point(550, 0);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 6;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66623F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66623F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66623F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66623F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66623F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66887F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(397, 575);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(7, 482);
            this.label4.Margin = new System.Windows.Forms.Padding(5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(234, 86);
            this.label4.TabIndex = 11;
            this.label4.Text = "Progress";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // progressLabel
            // 
            this.progressLabel.AutoSize = true;
            this.progressLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressLabel.Location = new System.Drawing.Point(253, 482);
            this.progressLabel.Margin = new System.Windows.Forms.Padding(5);
            this.progressLabel.Name = "progressLabel";
            this.progressLabel.Size = new System.Drawing.Size(137, 86);
            this.progressLabel.TabIndex = 10;
            this.progressLabel.Text = "0%";
            this.progressLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.timeLabel.Location = new System.Drawing.Point(253, 387);
            this.timeLabel.Margin = new System.Windows.Forms.Padding(5);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(137, 83);
            this.timeLabel.TabIndex = 9;
            this.timeLabel.Text = "00:00";
            this.timeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Location = new System.Drawing.Point(7, 387);
            this.label9.Margin = new System.Windows.Forms.Padding(5);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(234, 83);
            this.label9.TabIndex = 8;
            this.label9.Text = "Time";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // accuracyLabel
            // 
            this.accuracyLabel.AutoSize = true;
            this.accuracyLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.accuracyLabel.Location = new System.Drawing.Point(253, 292);
            this.accuracyLabel.Margin = new System.Windows.Forms.Padding(5);
            this.accuracyLabel.Name = "accuracyLabel";
            this.accuracyLabel.Size = new System.Drawing.Size(137, 83);
            this.accuracyLabel.TabIndex = 7;
            this.accuracyLabel.Text = "100%";
            this.accuracyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Location = new System.Drawing.Point(7, 292);
            this.label7.Margin = new System.Windows.Forms.Padding(5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(234, 83);
            this.label7.TabIndex = 6;
            this.label7.Text = "Accuracy";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mistakesLabel
            // 
            this.mistakesLabel.AutoSize = true;
            this.mistakesLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mistakesLabel.Location = new System.Drawing.Point(253, 197);
            this.mistakesLabel.Margin = new System.Windows.Forms.Padding(5);
            this.mistakesLabel.Name = "mistakesLabel";
            this.mistakesLabel.Size = new System.Drawing.Size(137, 83);
            this.mistakesLabel.TabIndex = 5;
            this.mistakesLabel.Text = "0";
            this.mistakesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(7, 197);
            this.label5.Margin = new System.Windows.Forms.Padding(5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(234, 83);
            this.label5.TabIndex = 4;
            this.label5.Text = "Mistakes";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // symbolsLabel
            // 
            this.symbolsLabel.AutoSize = true;
            this.symbolsLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.symbolsLabel.Location = new System.Drawing.Point(253, 102);
            this.symbolsLabel.Margin = new System.Windows.Forms.Padding(5);
            this.symbolsLabel.Name = "symbolsLabel";
            this.symbolsLabel.Size = new System.Drawing.Size(137, 83);
            this.symbolsLabel.TabIndex = 3;
            this.symbolsLabel.Text = "0";
            this.symbolsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(7, 102);
            this.label3.Margin = new System.Windows.Forms.Padding(5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(234, 83);
            this.label3.TabIndex = 2;
            this.label3.Text = "Symbols";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(7, 7);
            this.label2.Margin = new System.Windows.Forms.Padding(5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 83);
            this.label2.TabIndex = 1;
            this.label2.Text = "Symbols in minute";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // symbolsInMinuteLabel
            // 
            this.symbolsInMinuteLabel.AutoSize = true;
            this.symbolsInMinuteLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.symbolsInMinuteLabel.Location = new System.Drawing.Point(253, 7);
            this.symbolsInMinuteLabel.Margin = new System.Windows.Forms.Padding(5);
            this.symbolsInMinuteLabel.Name = "symbolsInMinuteLabel";
            this.symbolsInMinuteLabel.Size = new System.Drawing.Size(137, 83);
            this.symbolsInMinuteLabel.TabIndex = 0;
            this.symbolsInMinuteLabel.Text = "0";
            this.symbolsInMinuteLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.printableTextBox, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.toPrintTextBox, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.pauseButton, 0, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(550, 575);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // printableTextBox
            // 
            this.printableTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.printableTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.printableTextBox.Location = new System.Drawing.Point(8, 280);
            this.printableTextBox.Margin = new System.Windows.Forms.Padding(8);
            this.printableTextBox.Name = "printableTextBox";
            this.printableTextBox.ReadOnly = true;
            this.printableTextBox.Size = new System.Drawing.Size(534, 256);
            this.printableTextBox.TabIndex = 1;
            this.printableTextBox.Text = "";
            // 
            // toPrintTextBox
            // 
            this.toPrintTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toPrintTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toPrintTextBox.Location = new System.Drawing.Point(8, 8);
            this.toPrintTextBox.Margin = new System.Windows.Forms.Padding(8);
            this.toPrintTextBox.Name = "toPrintTextBox";
            this.toPrintTextBox.Size = new System.Drawing.Size(534, 256);
            this.toPrintTextBox.TabIndex = 0;
            this.toPrintTextBox.Text = "";
            this.toPrintTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.toPrintTextBox_KeyUp);
            // 
            // pauseButton
            // 
            this.pauseButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.pauseButton.Location = new System.Drawing.Point(472, 547);
            this.pauseButton.Name = "pauseButton";
            this.pauseButton.Size = new System.Drawing.Size(75, 25);
            this.pauseButton.TabIndex = 2;
            this.pauseButton.Text = "Pause";
            this.pauseButton.UseVisualStyleBackColor = true;
            this.pauseButton.Click += new System.EventHandler(this.pauseButton_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 575);
            this.Controls.Add(this.tableLayoutPanel1);
            this.DoubleBuffered = true;
            this.Name = "StartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KeyboardSimulator";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.RichTextBox toPrintTextBox;
        private System.Windows.Forms.RichTextBox printableTextBox;
        private System.Windows.Forms.Button pauseButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label accuracyLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label mistakesLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label symbolsLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label symbolsInMinuteLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label progressLabel;
    }
}
namespace TournamentTrackerUI
{
    partial class TournamentViewerForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TournamentNameLabel = new Label();
            TournamentName = new Label();
            RoundLabel = new Label();
            RoundsDropDown = new ComboBox();
            checkBox1 = new CheckBox();
            SuspendLayout();
            // 
            // TournamentNameLabel
            // 
            TournamentNameLabel.AutoSize = true;
            TournamentNameLabel.Font = new Font("Tahoma", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            TournamentNameLabel.ForeColor = SystemColors.Highlight;
            TournamentNameLabel.Location = new Point(50, 42);
            TournamentNameLabel.Name = "TournamentNameLabel";
            TournamentNameLabel.Size = new Size(271, 35);
            TournamentNameLabel.TabIndex = 6;
            TournamentNameLabel.Text = "Tournament Name: ";
            TournamentNameLabel.UseMnemonic = false;
            // 
            // TournamentName
            // 
            TournamentName.AutoSize = true;
            TournamentName.Font = new Font("Tahoma", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            TournamentName.ForeColor = SystemColors.Highlight;
            TournamentName.Location = new Point(317, 42);
            TournamentName.Name = "TournamentName";
            TournamentName.Size = new Size(284, 35);
            TournamentName.TabIndex = 7;
            TournamentName.Text = "<tournament name>";
            TournamentName.UseMnemonic = false;
            // 
            // RoundLabel
            // 
            RoundLabel.AutoSize = true;
            RoundLabel.Font = new Font("Tahoma", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            RoundLabel.ForeColor = SystemColors.Highlight;
            RoundLabel.Location = new Point(50, 112);
            RoundLabel.Name = "RoundLabel";
            RoundLabel.Size = new Size(107, 35);
            RoundLabel.TabIndex = 8;
            RoundLabel.Text = "Round:";
            RoundLabel.UseMnemonic = false;
            // 
            // RoundsDropDown
            // 
            RoundsDropDown.ForeColor = SystemColors.Highlight;
            RoundsDropDown.FormattingEnabled = true;
            RoundsDropDown.Location = new Point(163, 124);
            RoundsDropDown.Name = "RoundsDropDown";
            RoundsDropDown.Size = new Size(169, 23);
            RoundsDropDown.TabIndex = 9;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(60, 171);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(83, 19);
            checkBox1.TabIndex = 10;
            checkBox1.Text = "checkBox1";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // TournamentViewerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(871, 692);
            Controls.Add(checkBox1);
            Controls.Add(RoundsDropDown);
            Controls.Add(RoundLabel);
            Controls.Add(TournamentName);
            Controls.Add(TournamentNameLabel);
            ForeColor = SystemColors.Highlight;
            Name = "TournamentViewerForm";
            Text = "Tournament Viewer Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label TournamentNameLabel;
        private Label TournamentName;
        private Label RoundLabel;
        private ComboBox RoundsDropDown;
        private CheckBox checkBox1;
    }
}
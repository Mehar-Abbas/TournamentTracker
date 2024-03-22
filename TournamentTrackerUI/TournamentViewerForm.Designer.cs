﻿namespace TournamentTrackerUI
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
            UnplayedCheckbox = new CheckBox();
            MatchupListBox = new ListBox();
            Team1ScoreLabel = new Label();
            Team2ScoreLabel = new Label();
            VSLabel = new Label();
            ScoreButton = new Button();
            TeamOneTextBox = new TextBox();
            TeamTwoTextBox = new TextBox();
            SuspendLayout();
            // 
            // TournamentNameLabel
            // 
            TournamentNameLabel.AutoSize = true;
            TournamentNameLabel.Font = new Font("Tahoma", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            TournamentNameLabel.ForeColor = SystemColors.Highlight;
            TournamentNameLabel.Location = new Point(64, 59);
            TournamentNameLabel.Margin = new Padding(4, 0, 4, 0);
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
            TournamentName.Location = new Point(408, 59);
            TournamentName.Margin = new Padding(4, 0, 4, 0);
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
            RoundLabel.Location = new Point(64, 157);
            RoundLabel.Margin = new Padding(4, 0, 4, 0);
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
            RoundsDropDown.Location = new Point(170, 163);
            RoundsDropDown.Margin = new Padding(4, 4, 4, 4);
            RoundsDropDown.Name = "RoundsDropDown";
            RoundsDropDown.Size = new Size(216, 29);
            RoundsDropDown.TabIndex = 9;
            // 
            // UnplayedCheckbox
            // 
            UnplayedCheckbox.Checked = true;
            UnplayedCheckbox.CheckState = CheckState.Checked;
            UnplayedCheckbox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            UnplayedCheckbox.Location = new Point(78, 245);
            UnplayedCheckbox.Margin = new Padding(4, 4, 4, 4);
            UnplayedCheckbox.Name = "UnplayedCheckbox";
            UnplayedCheckbox.Size = new Size(248, 48);
            UnplayedCheckbox.TabIndex = 10;
            UnplayedCheckbox.Text = "Unplayed games only";
            UnplayedCheckbox.UseVisualStyleBackColor = true;
            // 
            // MatchupListBox
            // 
            MatchupListBox.ForeColor = SystemColors.Highlight;
            MatchupListBox.FormattingEnabled = true;
            MatchupListBox.ItemHeight = 21;
            MatchupListBox.Location = new Point(78, 351);
            MatchupListBox.Margin = new Padding(4, 4, 4, 4);
            MatchupListBox.Name = "MatchupListBox";
            MatchupListBox.Size = new Size(372, 382);
            MatchupListBox.TabIndex = 11;
            // 
            // Team1ScoreLabel
            // 
            Team1ScoreLabel.AutoSize = true;
            Team1ScoreLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            Team1ScoreLabel.Location = new Point(576, 391);
            Team1ScoreLabel.Name = "Team1ScoreLabel";
            Team1ScoreLabel.Size = new Size(150, 32);
            Team1ScoreLabel.TabIndex = 12;
            Team1ScoreLabel.Text = "Team1 Score";
            // 
            // Team2ScoreLabel
            // 
            Team2ScoreLabel.AutoSize = true;
            Team2ScoreLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            Team2ScoreLabel.Location = new Point(576, 616);
            Team2ScoreLabel.Name = "Team2ScoreLabel";
            Team2ScoreLabel.Size = new Size(150, 32);
            Team2ScoreLabel.TabIndex = 13;
            Team2ScoreLabel.Text = "Team2 Score";
            // 
            // VSLabel
            // 
            VSLabel.AutoSize = true;
            VSLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            VSLabel.Location = new Point(630, 511);
            VSLabel.Name = "VSLabel";
            VSLabel.Size = new Size(62, 32);
            VSLabel.TabIndex = 14;
            VSLabel.Text = "-VS-";
            // 
            // ScoreButton
            // 
            ScoreButton.BackColor = Color.Gainsboro;
            ScoreButton.FlatAppearance.MouseDownBackColor = Color.Silver;
            ScoreButton.FlatAppearance.MouseOverBackColor = Color.LightGray;
            ScoreButton.FlatStyle = FlatStyle.Flat;
            ScoreButton.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            ScoreButton.Location = new Point(876, 499);
            ScoreButton.Name = "ScoreButton";
            ScoreButton.Size = new Size(136, 53);
            ScoreButton.TabIndex = 15;
            ScoreButton.Text = "Score";
            ScoreButton.UseVisualStyleBackColor = false;
            // 
            // TeamOneTextBox
            // 
            TeamOneTextBox.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            TeamOneTextBox.Location = new Point(732, 391);
            TeamOneTextBox.Name = "TeamOneTextBox";
            TeamOneTextBox.Size = new Size(100, 35);
            TeamOneTextBox.TabIndex = 16;
            // 
            // TeamTwoTextBox
            // 
            TeamTwoTextBox.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            TeamTwoTextBox.Location = new Point(732, 616);
            TeamTwoTextBox.Name = "TeamTwoTextBox";
            TeamTwoTextBox.Size = new Size(100, 35);
            TeamTwoTextBox.TabIndex = 17;
            // 
            // TournamentViewerForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1120, 969);
            Controls.Add(TeamTwoTextBox);
            Controls.Add(TeamOneTextBox);
            Controls.Add(ScoreButton);
            Controls.Add(VSLabel);
            Controls.Add(Team2ScoreLabel);
            Controls.Add(Team1ScoreLabel);
            Controls.Add(MatchupListBox);
            Controls.Add(UnplayedCheckbox);
            Controls.Add(RoundsDropDown);
            Controls.Add(RoundLabel);
            Controls.Add(TournamentName);
            Controls.Add(TournamentNameLabel);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = SystemColors.Highlight;
            Margin = new Padding(4, 4, 4, 4);
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
        private CheckBox UnplayedCheckbox;
        private ListBox MatchupListBox;
        private Label Team1ScoreLabel;
        private Label Team2ScoreLabel;
        private Label VSLabel;
        private Button ScoreButton;
        private TextBox TeamOneTextBox;
        private TextBox TeamTwoTextBox;
    }
}
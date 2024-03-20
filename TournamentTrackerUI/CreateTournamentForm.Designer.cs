namespace TournamentTrackerUI
{
    partial class CreateTournamtForm
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
            TournamentNameLabel = new Label();
            CreateTournamentNameLabel = new Label();
            EntryFeeLabel = new Label();
            SuspendLayout();
            // 
            // TournamentNameLabel
            // 
            TournamentNameLabel.AutoSize = true;
            TournamentNameLabel.Font = new Font("Tahoma", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            TournamentNameLabel.ForeColor = SystemColors.Highlight;
            TournamentNameLabel.Location = new Point(23, 40);
            TournamentNameLabel.Name = "TournamentNameLabel";
            TournamentNameLabel.Size = new Size(335, 45);
            TournamentNameLabel.TabIndex = 1;
            TournamentNameLabel.Text = "Create Tournament";
            TournamentNameLabel.UseMnemonic = false;
            // 
            // CreateTournamentNameLabel
            // 
            CreateTournamentNameLabel.AutoSize = true;
            CreateTournamentNameLabel.Font = new Font("Tahoma", 18F, FontStyle.Regular, GraphicsUnit.Point);
            CreateTournamentNameLabel.ForeColor = SystemColors.Highlight;
            CreateTournamentNameLabel.Location = new Point(23, 145);
            CreateTournamentNameLabel.Name = "CreateTournamentNameLabel";
            CreateTournamentNameLabel.Size = new Size(228, 29);
            CreateTournamentNameLabel.TabIndex = 2;
            CreateTournamentNameLabel.Text = "Tournament Name :";
            // 
            // EntryFeeLabel
            // 
            EntryFeeLabel.AutoSize = true;
            EntryFeeLabel.Font = new Font("Tahoma", 18F, FontStyle.Regular, GraphicsUnit.Point);
            EntryFeeLabel.ForeColor = SystemColors.Highlight;
            EntryFeeLabel.Location = new Point(23, 206);
            EntryFeeLabel.Name = "EntryFeeLabel";
            EntryFeeLabel.Size = new Size(123, 29);
            EntryFeeLabel.TabIndex = 3;
            EntryFeeLabel.Text = "Entry Fee:";
            // 
            // CreateTournamtForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(800, 774);
            Controls.Add(EntryFeeLabel);
            Controls.Add(CreateTournamentNameLabel);
            Controls.Add(TournamentNameLabel);
            Name = "CreateTournamtForm";
            Text = "Create Tournament";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label TournamentNameLabel;
        private Label CreateTournamentNameLabel;
        private Label EntryFeeLabel;
    }
}
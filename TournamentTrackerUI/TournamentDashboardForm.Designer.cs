namespace TournamentTrackerUI
{
    partial class TournamentDashboardForm
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
            TournamentDashboardLabel = new Label();
            TeamSelectionBox = new ComboBox();
            SelectExistingTournamentNameLabel = new Label();
            LoadTournamentButton = new Button();
            CreateNewTournamentButton = new Button();
            SuspendLayout();
            // 
            // TournamentDashboardLabel
            // 
            TournamentDashboardLabel.AutoSize = true;
            TournamentDashboardLabel.Font = new Font("Tahoma", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            TournamentDashboardLabel.ForeColor = SystemColors.Highlight;
            TournamentDashboardLabel.Location = new Point(165, 40);
            TournamentDashboardLabel.Name = "TournamentDashboardLabel";
            TournamentDashboardLabel.Size = new Size(405, 45);
            TournamentDashboardLabel.TabIndex = 5;
            TournamentDashboardLabel.Text = "Tournament Dashboard";
            TournamentDashboardLabel.UseMnemonic = false;
            // 
            // TeamSelectionBox
            // 
            TeamSelectionBox.AutoCompleteSource = AutoCompleteSource.ListItems;
            TeamSelectionBox.BackColor = Color.White;
            TeamSelectionBox.DropDownWidth = 121;
            TeamSelectionBox.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            TeamSelectionBox.ForeColor = SystemColors.Highlight;
            TeamSelectionBox.FormattingEnabled = true;
            TeamSelectionBox.IntegralHeight = false;
            TeamSelectionBox.ItemHeight = 16;
            TeamSelectionBox.Location = new Point(361, 161);
            TeamSelectionBox.Name = "TeamSelectionBox";
            TeamSelectionBox.Size = new Size(277, 24);
            TeamSelectionBox.TabIndex = 32;
            TeamSelectionBox.Text = "Choose a tournament name......";
            // 
            // SelectExistingTournamentNameLabel
            // 
            SelectExistingTournamentNameLabel.AutoSize = true;
            SelectExistingTournamentNameLabel.Font = new Font("Tahoma", 18F, FontStyle.Regular, GraphicsUnit.Point);
            SelectExistingTournamentNameLabel.ForeColor = SystemColors.Highlight;
            SelectExistingTournamentNameLabel.Location = new Point(46, 156);
            SelectExistingTournamentNameLabel.Name = "SelectExistingTournamentNameLabel";
            SelectExistingTournamentNameLabel.Size = new Size(309, 29);
            SelectExistingTournamentNameLabel.TabIndex = 31;
            SelectExistingTournamentNameLabel.Text = "Select Existing Tournament:";
            // 
            // LoadTournamentButton
            // 
            LoadTournamentButton.BackColor = Color.White;
            LoadTournamentButton.FlatAppearance.BorderColor = Color.Silver;
            LoadTournamentButton.FlatAppearance.MouseDownBackColor = Color.DarkGray;
            LoadTournamentButton.FlatAppearance.MouseOverBackColor = Color.White;
            LoadTournamentButton.FlatStyle = FlatStyle.Flat;
            LoadTournamentButton.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            LoadTournamentButton.ForeColor = SystemColors.Highlight;
            LoadTournamentButton.ImageAlign = ContentAlignment.MiddleLeft;
            LoadTournamentButton.Location = new Point(107, 269);
            LoadTournamentButton.Name = "LoadTournamentButton";
            LoadTournamentButton.Size = new Size(243, 44);
            LoadTournamentButton.TabIndex = 33;
            LoadTournamentButton.Text = "Load Tournament";
            LoadTournamentButton.UseVisualStyleBackColor = false;
            // 
            // CreateNewTournamentButton
            // 
            CreateNewTournamentButton.BackColor = Color.White;
            CreateNewTournamentButton.FlatAppearance.BorderColor = Color.Silver;
            CreateNewTournamentButton.FlatAppearance.MouseDownBackColor = Color.DarkGray;
            CreateNewTournamentButton.FlatAppearance.MouseOverBackColor = Color.White;
            CreateNewTournamentButton.FlatStyle = FlatStyle.Flat;
            CreateNewTournamentButton.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            CreateNewTournamentButton.ForeColor = SystemColors.Highlight;
            CreateNewTournamentButton.ImageAlign = ContentAlignment.MiddleLeft;
            CreateNewTournamentButton.Location = new Point(371, 269);
            CreateNewTournamentButton.Name = "CreateNewTournamentButton";
            CreateNewTournamentButton.Size = new Size(243, 44);
            CreateNewTournamentButton.TabIndex = 34;
            CreateNewTournamentButton.Text = "Create New Tournament";
            CreateNewTournamentButton.UseVisualStyleBackColor = false;
            // 
            // TournamentDashBoardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(736, 464);
            Controls.Add(CreateNewTournamentButton);
            Controls.Add(LoadTournamentButton);
            Controls.Add(TeamSelectionBox);
            Controls.Add(SelectExistingTournamentNameLabel);
            Controls.Add(TournamentDashboardLabel);
            Name = "TournamentDashboardForm";
            Text = "Tournament Dashboard";
            Load += TournamentDashboardForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label TournamentDashboardLabel;
        private ComboBox TeamSelectionBox;
        private Label SelectExistingTournamentNameLabel;
        public Button LoadTournamentButton;
        public Button CreateNewTournamentButton;
    }
}
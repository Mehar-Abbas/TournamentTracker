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
            EntryFeeTextBox = new TextBox();
            CreateTournamentTextBox = new TextBox();
            SelectTeamLabel = new Label();
            TeamsOrPlayersLabel = new Label();
            PrizesLabel = new Label();
            AddTeamButton = new Button();
            button2 = new Button();
            CreatePrizeButton = new Button();
            DeletePrizeButton = new Button();
            CreateNewTeamLink = new LinkLabel();
            TeamsOrPlayersListBox = new ListBox();
            PrizesListBox = new ListBox();
            SelectTeamDropdown = new ComboBox();
            CreateTournamentButton = new Button();
            SuspendLayout();
            // 
            // TournamentNameLabel
            // 
            TournamentNameLabel.AutoSize = true;
            TournamentNameLabel.Font = new Font("Tahoma", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            TournamentNameLabel.ForeColor = SystemColors.Highlight;
            TournamentNameLabel.Location = new Point(118, 40);
            TournamentNameLabel.Name = "TournamentNameLabel";
            TournamentNameLabel.Size = new Size(381, 45);
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
            // EntryFeeTextBox
            // 
            EntryFeeTextBox.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            EntryFeeTextBox.Location = new Point(151, 200);
            EntryFeeTextBox.Name = "EntryFeeTextBox";
            EntryFeeTextBox.Size = new Size(100, 35);
            EntryFeeTextBox.TabIndex = 4;
            // 
            // CreateTournamentTextBox
            // 
            CreateTournamentTextBox.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            CreateTournamentTextBox.Location = new Point(257, 139);
            CreateTournamentTextBox.Name = "CreateTournamentTextBox";
            CreateTournamentTextBox.Size = new Size(305, 35);
            CreateTournamentTextBox.TabIndex = 5;
            // 
            // SelectTeamLabel
            // 
            SelectTeamLabel.AutoSize = true;
            SelectTeamLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            SelectTeamLabel.ForeColor = SystemColors.Highlight;
            SelectTeamLabel.Location = new Point(23, 330);
            SelectTeamLabel.Name = "SelectTeamLabel";
            SelectTeamLabel.Size = new Size(147, 32);
            SelectTeamLabel.TabIndex = 6;
            SelectTeamLabel.Text = "Select Team:";
            // 
            // TeamsOrPlayersLabel
            // 
            TeamsOrPlayersLabel.AutoSize = true;
            TeamsOrPlayersLabel.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            TeamsOrPlayersLabel.ForeColor = SystemColors.Highlight;
            TeamsOrPlayersLabel.Location = new Point(611, 55);
            TeamsOrPlayersLabel.Name = "TeamsOrPlayersLabel";
            TeamsOrPlayersLabel.Size = new Size(149, 30);
            TeamsOrPlayersLabel.TabIndex = 7;
            TeamsOrPlayersLabel.Text = "Teams/Players";
            TeamsOrPlayersLabel.Click += TeamsOrPlayersLabel_Click;
            // 
            // PrizesLabel
            // 
            PrizesLabel.AutoSize = true;
            PrizesLabel.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            PrizesLabel.ForeColor = SystemColors.Highlight;
            PrizesLabel.Location = new Point(611, 536);
            PrizesLabel.Name = "PrizesLabel";
            PrizesLabel.Size = new Size(68, 30);
            PrizesLabel.TabIndex = 8;
            PrizesLabel.Text = "Prizes";
            // 
            // AddTeamButton
            // 
            AddTeamButton.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            AddTeamButton.ForeColor = SystemColors.Highlight;
            AddTeamButton.Location = new Point(52, 453);
            AddTeamButton.Name = "AddTeamButton";
            AddTeamButton.Size = new Size(211, 53);
            AddTeamButton.TabIndex = 9;
            AddTeamButton.Text = "Add Team";
            AddTeamButton.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.Highlight;
            button2.Location = new Point(309, 453);
            button2.Name = "button2";
            button2.Size = new Size(202, 53);
            button2.TabIndex = 10;
            button2.Text = "Delete Team";
            button2.UseVisualStyleBackColor = true;
            // 
            // CreatePrizeButton
            // 
            CreatePrizeButton.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            CreatePrizeButton.ForeColor = SystemColors.Highlight;
            CreatePrizeButton.Location = new Point(52, 553);
            CreatePrizeButton.Name = "CreatePrizeButton";
            CreatePrizeButton.Size = new Size(211, 50);
            CreatePrizeButton.TabIndex = 11;
            CreatePrizeButton.Text = "Create Prize";
            CreatePrizeButton.UseVisualStyleBackColor = true;
            // 
            // DeletePrizeButton
            // 
            DeletePrizeButton.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            DeletePrizeButton.ForeColor = SystemColors.Highlight;
            DeletePrizeButton.Location = new Point(309, 553);
            DeletePrizeButton.Name = "DeletePrizeButton";
            DeletePrizeButton.Size = new Size(193, 48);
            DeletePrizeButton.TabIndex = 12;
            DeletePrizeButton.Text = "Delete Prize";
            DeletePrizeButton.UseVisualStyleBackColor = true;
            // 
            // CreateNewTeamLink
            // 
            CreateNewTeamLink.AutoSize = true;
            CreateNewTeamLink.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point);
            CreateNewTeamLink.Location = new Point(176, 365);
            CreateNewTeamLink.Name = "CreateNewTeamLink";
            CreateNewTeamLink.Size = new Size(135, 21);
            CreateNewTeamLink.TabIndex = 13;
            CreateNewTeamLink.TabStop = true;
            CreateNewTeamLink.Text = "Create New Team";
            // 
            // TeamsOrPlayersListBox
            // 
            TeamsOrPlayersListBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TeamsOrPlayersListBox.ForeColor = SystemColors.Highlight;
            TeamsOrPlayersListBox.FormattingEnabled = true;
            TeamsOrPlayersListBox.ItemHeight = 21;
            TeamsOrPlayersListBox.Location = new Point(611, 88);
            TeamsOrPlayersListBox.Name = "TeamsOrPlayersListBox";
            TeamsOrPlayersListBox.Size = new Size(445, 424);
            TeamsOrPlayersListBox.TabIndex = 14;
            // 
            // PrizesListBox
            // 
            PrizesListBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PrizesListBox.ForeColor = SystemColors.Highlight;
            PrizesListBox.FormattingEnabled = true;
            PrizesListBox.ItemHeight = 21;
            PrizesListBox.Location = new Point(611, 569);
            PrizesListBox.Name = "PrizesListBox";
            PrizesListBox.Size = new Size(445, 172);
            PrizesListBox.TabIndex = 15;
            // 
            // SelectTeamDropdown
            // 
            SelectTeamDropdown.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            SelectTeamDropdown.ForeColor = SystemColors.Highlight;
            SelectTeamDropdown.FormattingEnabled = true;
            SelectTeamDropdown.Location = new Point(176, 324);
            SelectTeamDropdown.Name = "SelectTeamDropdown";
            SelectTeamDropdown.Size = new Size(323, 38);
            SelectTeamDropdown.TabIndex = 16;
            // 
            // CreateTournamentButton
            // 
            CreateTournamentButton.BackColor = Color.Gainsboro;
            CreateTournamentButton.FlatAppearance.MouseDownBackColor = Color.Silver;
            CreateTournamentButton.FlatAppearance.MouseOverBackColor = Color.LightGray;
            CreateTournamentButton.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            CreateTournamentButton.ForeColor = SystemColors.Highlight;
            CreateTournamentButton.Location = new Point(52, 682);
            CreateTournamentButton.Name = "CreateTournamentButton";
            CreateTournamentButton.Size = new Size(447, 63);
            CreateTournamentButton.TabIndex = 17;
            CreateTournamentButton.Text = "Create Tournament";
            CreateTournamentButton.UseVisualStyleBackColor = false;
            // 
            // CreateTournamtForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1101, 835);
            Controls.Add(CreateTournamentButton);
            Controls.Add(SelectTeamDropdown);
            Controls.Add(PrizesListBox);
            Controls.Add(TeamsOrPlayersListBox);
            Controls.Add(CreateNewTeamLink);
            Controls.Add(DeletePrizeButton);
            Controls.Add(CreatePrizeButton);
            Controls.Add(button2);
            Controls.Add(AddTeamButton);
            Controls.Add(PrizesLabel);
            Controls.Add(TeamsOrPlayersLabel);
            Controls.Add(SelectTeamLabel);
            Controls.Add(CreateTournamentTextBox);
            Controls.Add(EntryFeeTextBox);
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
        private TextBox EntryFeeTextBox;
        private TextBox CreateTournamentTextBox;
        private Label SelectTeamLabel;
        private Label TeamsOrPlayersLabel;
        private Label PrizesLabel;
        private Button AddTeamButton;
        private Button button2;
        private Button CreatePrizeButton;
        private Button DeletePrizeButton;
        private LinkLabel CreateNewTeamLink;
        private ListBox TeamsOrPlayersListBox;
        private ListBox PrizesListBox;
        private ComboBox SelectTeamDropdown;
        private Button CreateTournamentButton;
    }
}
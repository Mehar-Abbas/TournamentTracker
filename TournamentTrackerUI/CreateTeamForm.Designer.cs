namespace TournamentTrackerUI
{
    partial class CreateTeamForm
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
            CreateNewTeamLabel = new Label();
            TeamNameLabel = new Label();
            SelectTeamMembersLabel = new Label();
            SelectTeamMebbersDropdown = new ComboBox();
            AddMemberButton = new Button();
            DeleteMemberButton = new Button();
            CreateNewMemberLink = new LinkLabel();
            TeamMembersTextBox = new ListBox();
            CreateTeamButton = new Button();
            TeamNameTextBox = new TextBox();
            TeamMembersLabel = new Label();
            SuspendLayout();
            // 
            // CreateNewTeamLabel
            // 
            CreateNewTeamLabel.AutoSize = true;
            CreateNewTeamLabel.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            CreateNewTeamLabel.Location = new Point(85, 23);
            CreateNewTeamLabel.Name = "CreateNewTeamLabel";
            CreateNewTeamLabel.Size = new Size(326, 50);
            CreateNewTeamLabel.TabIndex = 0;
            CreateNewTeamLabel.Text = "Create New Team";
            // 
            // TeamNameLabel
            // 
            TeamNameLabel.AutoSize = true;
            TeamNameLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            TeamNameLabel.Location = new Point(35, 108);
            TeamNameLabel.Name = "TeamNameLabel";
            TeamNameLabel.Size = new Size(135, 30);
            TeamNameLabel.TabIndex = 1;
            TeamNameLabel.Text = "Team Name: ";
            // 
            // SelectTeamMembersLabel
            // 
            SelectTeamMembersLabel.AutoSize = true;
            SelectTeamMembersLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            SelectTeamMembersLabel.Location = new Point(35, 208);
            SelectTeamMembersLabel.Name = "SelectTeamMembersLabel";
            SelectTeamMembersLabel.Size = new Size(227, 30);
            SelectTeamMembersLabel.TabIndex = 2;
            SelectTeamMembersLabel.Text = "Select Team Members: ";
            SelectTeamMembersLabel.Click += SelectTeamMembersLabel_Click;
            // 
            // SelectTeamMebbersDropdown
            // 
            SelectTeamMebbersDropdown.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            SelectTeamMebbersDropdown.ForeColor = SystemColors.Highlight;
            SelectTeamMebbersDropdown.FormattingEnabled = true;
            SelectTeamMebbersDropdown.Location = new Point(35, 241);
            SelectTeamMebbersDropdown.Name = "SelectTeamMebbersDropdown";
            SelectTeamMebbersDropdown.Size = new Size(411, 38);
            SelectTeamMebbersDropdown.TabIndex = 3;
            // 
            // AddMemberButton
            // 
            AddMemberButton.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            AddMemberButton.Location = new Point(35, 351);
            AddMemberButton.Name = "AddMemberButton";
            AddMemberButton.Size = new Size(199, 61);
            AddMemberButton.TabIndex = 4;
            AddMemberButton.Text = "Add Member";
            AddMemberButton.UseVisualStyleBackColor = true;
            // 
            // DeleteMemberButton
            // 
            DeleteMemberButton.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            DeleteMemberButton.Location = new Point(240, 351);
            DeleteMemberButton.Name = "DeleteMemberButton";
            DeleteMemberButton.Size = new Size(206, 61);
            DeleteMemberButton.TabIndex = 5;
            DeleteMemberButton.Text = "Delete Member";
            DeleteMemberButton.UseVisualStyleBackColor = true;
            // 
            // CreateNewMemberLink
            // 
            CreateNewMemberLink.AutoSize = true;
            CreateNewMemberLink.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point);
            CreateNewMemberLink.Location = new Point(35, 296);
            CreateNewMemberLink.Name = "CreateNewMemberLink";
            CreateNewMemberLink.Size = new Size(167, 21);
            CreateNewMemberLink.TabIndex = 6;
            CreateNewMemberLink.TabStop = true;
            CreateNewMemberLink.Text = "Create a New Member";
            // 
            // TeamMembersTextBox
            // 
            TeamMembersTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TeamMembersTextBox.ForeColor = SystemColors.Highlight;
            TeamMembersTextBox.FormattingEnabled = true;
            TeamMembersTextBox.ItemHeight = 21;
            TeamMembersTextBox.Location = new Point(480, 86);
            TeamMembersTextBox.Name = "TeamMembersTextBox";
            TeamMembersTextBox.Size = new Size(294, 466);
            TeamMembersTextBox.TabIndex = 7;
            // 
            // CreateTeamButton
            // 
            CreateTeamButton.BackColor = Color.Gainsboro;
            CreateTeamButton.FlatAppearance.MouseDownBackColor = Color.Silver;
            CreateTeamButton.FlatAppearance.MouseOverBackColor = Color.LightGray;
            CreateTeamButton.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            CreateTeamButton.Location = new Point(25, 510);
            CreateTeamButton.Name = "CreateTeamButton";
            CreateTeamButton.Size = new Size(421, 60);
            CreateTeamButton.TabIndex = 8;
            CreateTeamButton.Text = "Create Team";
            CreateTeamButton.UseVisualStyleBackColor = false;
            // 
            // TeamNameTextBox
            // 
            TeamNameTextBox.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            TeamNameTextBox.ForeColor = SystemColors.Highlight;
            TeamNameTextBox.Location = new Point(35, 141);
            TeamNameTextBox.Name = "TeamNameTextBox";
            TeamNameTextBox.Size = new Size(411, 35);
            TeamNameTextBox.TabIndex = 9;
            // 
            // TeamMembersLabel
            // 
            TeamMembersLabel.AutoSize = true;
            TeamMembersLabel.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            TeamMembersLabel.Location = new Point(480, 58);
            TeamMembersLabel.Name = "TeamMembersLabel";
            TeamMembersLabel.Size = new Size(143, 25);
            TeamMembersLabel.TabIndex = 10;
            TeamMembersLabel.Text = "Team Members";
            // 
            // CreateTeamForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(800, 655);
            Controls.Add(TeamMembersLabel);
            Controls.Add(TeamNameTextBox);
            Controls.Add(CreateTeamButton);
            Controls.Add(TeamMembersTextBox);
            Controls.Add(CreateNewMemberLink);
            Controls.Add(DeleteMemberButton);
            Controls.Add(AddMemberButton);
            Controls.Add(SelectTeamMebbersDropdown);
            Controls.Add(SelectTeamMembersLabel);
            Controls.Add(TeamNameLabel);
            Controls.Add(CreateNewTeamLabel);
            ForeColor = SystemColors.Highlight;
            Name = "CreateTeamForm";
            Text = "Create Team";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label CreateNewTeamLabel;
        private Label TeamNameLabel;
        private Label SelectTeamMembersLabel;
        private ComboBox SelectTeamMebbersDropdown;
        private Button AddMemberButton;
        private Button DeleteMemberButton;
        private LinkLabel CreateNewMemberLink;
        private ListBox TeamMembersTextBox;
        private Button CreateTeamButton;
        private TextBox TeamNameTextBox;
        private Label TeamMembersLabel;
    }
}
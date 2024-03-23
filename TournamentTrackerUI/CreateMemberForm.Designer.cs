namespace TournamentTrackerUI
{
    partial class CreateMemberForm
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
            CreateNewMemberLabel = new Label();
            FirstNameLabel = new Label();
            LastNameLabel = new Label();
            EmailLabel = new Label();
            CellPhoneLabel = new Label();
            FirstNameTextBox = new TextBox();
            LastNameTextBox = new TextBox();
            EmailTextBox = new TextBox();
            CellPhoneTextBox = new TextBox();
            CreateMemberButton = new Button();
            SuspendLayout();
            // 
            // CreateNewMemberLabel
            // 
            CreateNewMemberLabel.AutoSize = true;
            CreateNewMemberLabel.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            CreateNewMemberLabel.ForeColor = SystemColors.Highlight;
            CreateNewMemberLabel.Location = new Point(166, 29);
            CreateNewMemberLabel.Name = "CreateNewMemberLabel";
            CreateNewMemberLabel.Size = new Size(380, 50);
            CreateNewMemberLabel.TabIndex = 0;
            CreateNewMemberLabel.Text = "Create New Member";
            // 
            // FirstNameLabel
            // 
            FirstNameLabel.AutoSize = true;
            FirstNameLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            FirstNameLabel.ForeColor = SystemColors.Highlight;
            FirstNameLabel.Location = new Point(107, 158);
            FirstNameLabel.Name = "FirstNameLabel";
            FirstNameLabel.Size = new Size(124, 30);
            FirstNameLabel.TabIndex = 1;
            FirstNameLabel.Text = "First Name: ";
            // 
            // LastNameLabel
            // 
            LastNameLabel.AutoSize = true;
            LastNameLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            LastNameLabel.ForeColor = SystemColors.Highlight;
            LastNameLabel.Location = new Point(107, 204);
            LastNameLabel.Name = "LastNameLabel";
            LastNameLabel.Size = new Size(123, 30);
            LastNameLabel.TabIndex = 2;
            LastNameLabel.Text = "Last Name: ";
            // 
            // EmailLabel
            // 
            EmailLabel.AutoSize = true;
            EmailLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            EmailLabel.ForeColor = SystemColors.Highlight;
            EmailLabel.Location = new Point(107, 245);
            EmailLabel.Name = "EmailLabel";
            EmailLabel.Size = new Size(74, 30);
            EmailLabel.TabIndex = 3;
            EmailLabel.Text = "Email: ";
            // 
            // CellPhoneLabel
            // 
            CellPhoneLabel.AutoSize = true;
            CellPhoneLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            CellPhoneLabel.ForeColor = SystemColors.Highlight;
            CellPhoneLabel.Location = new Point(107, 289);
            CellPhoneLabel.Name = "CellPhoneLabel";
            CellPhoneLabel.Size = new Size(123, 30);
            CellPhoneLabel.TabIndex = 4;
            CellPhoneLabel.Text = "Cell Phone: ";
            // 
            // FirstNameTextBox
            // 
            FirstNameTextBox.Location = new Point(231, 165);
            FirstNameTextBox.Name = "FirstNameTextBox";
            FirstNameTextBox.Size = new Size(304, 23);
            FirstNameTextBox.TabIndex = 5;
            // 
            // LastNameTextBox
            // 
            LastNameTextBox.Location = new Point(231, 213);
            LastNameTextBox.Name = "LastNameTextBox";
            LastNameTextBox.Size = new Size(304, 23);
            LastNameTextBox.TabIndex = 6;
            // 
            // EmailTextBox
            // 
            EmailTextBox.Location = new Point(231, 254);
            EmailTextBox.Name = "EmailTextBox";
            EmailTextBox.Size = new Size(304, 23);
            EmailTextBox.TabIndex = 7;
            // 
            // CellPhoneTextBox
            // 
            CellPhoneTextBox.Location = new Point(231, 298);
            CellPhoneTextBox.Name = "CellPhoneTextBox";
            CellPhoneTextBox.Size = new Size(304, 23);
            CellPhoneTextBox.TabIndex = 8;
            // 
            // CreateMemberButton
            // 
            CreateMemberButton.BackColor = Color.Gainsboro;
            CreateMemberButton.FlatAppearance.MouseDownBackColor = Color.Silver;
            CreateMemberButton.FlatAppearance.MouseOverBackColor = Color.LightGray;
            CreateMemberButton.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            CreateMemberButton.ForeColor = SystemColors.Highlight;
            CreateMemberButton.Location = new Point(141, 421);
            CreateMemberButton.Name = "CreateMemberButton";
            CreateMemberButton.Size = new Size(345, 58);
            CreateMemberButton.TabIndex = 9;
            CreateMemberButton.Text = "Create Member";
            CreateMemberButton.UseVisualStyleBackColor = false;
            // 
            // CreateMemberForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(665, 579);
            Controls.Add(CreateMemberButton);
            Controls.Add(CellPhoneTextBox);
            Controls.Add(EmailTextBox);
            Controls.Add(LastNameTextBox);
            Controls.Add(FirstNameTextBox);
            Controls.Add(CellPhoneLabel);
            Controls.Add(EmailLabel);
            Controls.Add(LastNameLabel);
            Controls.Add(FirstNameLabel);
            Controls.Add(CreateNewMemberLabel);
            Name = "CreateMemberForm";
            Text = "CreateMember";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label CreateNewMemberLabel;
        private Label FirstNameLabel;
        private Label LastNameLabel;
        private Label EmailLabel;
        private Label CellPhoneLabel;
        private TextBox FirstNameTextBox;
        private TextBox LastNameTextBox;
        private TextBox EmailTextBox;
        private TextBox CellPhoneTextBox;
        private Button CreateMemberButton;
    }
}
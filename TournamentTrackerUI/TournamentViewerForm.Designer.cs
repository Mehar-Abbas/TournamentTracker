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
            TournamentDashboardLabel = new Label();
            SuspendLayout();
            // 
            // TournamentDashboardLabel
            // 
            TournamentDashboardLabel.AutoSize = true;
            TournamentDashboardLabel.Font = new Font("Tahoma", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            TournamentDashboardLabel.ForeColor = SystemColors.Highlight;
            TournamentDashboardLabel.Location = new Point(50, 42);
            TournamentDashboardLabel.Name = "TournamentDashboardLabel";
            TournamentDashboardLabel.Size = new Size(244, 45);
            TournamentDashboardLabel.TabIndex = 6;
            TournamentDashboardLabel.Text = "Tournament: ";
            TournamentDashboardLabel.UseMnemonic = false;
            // 
            // TournamentViewerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(871, 692);
            Controls.Add(TournamentDashboardLabel);
            ForeColor = SystemColors.Highlight;
            Name = "TournamentViewerForm";
            Text = "Tournament Viewer Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label TournamentDashboardLabel;
    }
}

namespace TrackerUI
{
    partial class TournamentViewrForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TournamentViewrForm));
            this.headerLabel = new System.Windows.Forms.Label();
            this.TournamentName = new System.Windows.Forms.Label();
            this.RoundLabel = new System.Windows.Forms.Label();
            this.RoundDropDown = new System.Windows.Forms.ComboBox();
            this.UnplayedCheck = new System.Windows.Forms.CheckBox();
            this.MatchupListBox = new System.Windows.Forms.ListBox();
            this.Team1Label = new System.Windows.Forms.Label();
            this.Team1ScoreLabel = new System.Windows.Forms.Label();
            this.Team1ScoretextBox = new System.Windows.Forms.TextBox();
            this.Team2ScoretextBox = new System.Windows.Forms.TextBox();
            this.Team2ScoreLabel = new System.Windows.Forms.Label();
            this.Team2Label = new System.Windows.Forms.Label();
            this.VsLabel = new System.Windows.Forms.Label();
            this.ScoreBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Location = new System.Drawing.Point(52, 23);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(171, 38);
            this.headerLabel.TabIndex = 0;
            this.headerLabel.Text = "Tournament:";
            this.headerLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // TournamentName
            // 
            this.TournamentName.AutoSize = true;
            this.TournamentName.Location = new System.Drawing.Point(220, 23);
            this.TournamentName.Name = "TournamentName";
            this.TournamentName.Size = new System.Drawing.Size(118, 38);
            this.TournamentName.TabIndex = 1;
            this.TournamentName.Text = "<none>";
            // 
            // RoundLabel
            // 
            this.RoundLabel.AutoSize = true;
            this.RoundLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RoundLabel.Location = new System.Drawing.Point(52, 95);
            this.RoundLabel.Name = "RoundLabel";
            this.RoundLabel.Size = new System.Drawing.Size(73, 28);
            this.RoundLabel.TabIndex = 2;
            this.RoundLabel.Text = "Round:";
            this.RoundLabel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // RoundDropDown
            // 
            this.RoundDropDown.FormattingEnabled = true;
            this.RoundDropDown.Location = new System.Drawing.Point(161, 92);
            this.RoundDropDown.Name = "RoundDropDown";
            this.RoundDropDown.Size = new System.Drawing.Size(151, 45);
            this.RoundDropDown.TabIndex = 3;
            this.RoundDropDown.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // UnplayedCheck
            // 
            this.UnplayedCheck.AutoSize = true;
            this.UnplayedCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UnplayedCheck.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UnplayedCheck.Location = new System.Drawing.Point(161, 143);
            this.UnplayedCheck.Name = "UnplayedCheck";
            this.UnplayedCheck.Size = new System.Drawing.Size(160, 32);
            this.UnplayedCheck.TabIndex = 4;
            this.UnplayedCheck.Text = "Unplayed Only";
            this.UnplayedCheck.UseVisualStyleBackColor = true;
            this.UnplayedCheck.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // MatchupListBox
            // 
            this.MatchupListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MatchupListBox.FormattingEnabled = true;
            this.MatchupListBox.ItemHeight = 37;
            this.MatchupListBox.Location = new System.Drawing.Point(52, 181);
            this.MatchupListBox.Name = "MatchupListBox";
            this.MatchupListBox.Size = new System.Drawing.Size(269, 224);
            this.MatchupListBox.TabIndex = 5;
            this.MatchupListBox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Team1Label
            // 
            this.Team1Label.AutoSize = true;
            this.Team1Label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Team1Label.Location = new System.Drawing.Point(379, 181);
            this.Team1Label.Name = "Team1Label";
            this.Team1Label.Size = new System.Drawing.Size(101, 28);
            this.Team1Label.TabIndex = 6;
            this.Team1Label.Text = "<Team 1>";
            // 
            // Team1ScoreLabel
            // 
            this.Team1ScoreLabel.AutoSize = true;
            this.Team1ScoreLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Team1ScoreLabel.Location = new System.Drawing.Point(379, 218);
            this.Team1ScoreLabel.Name = "Team1ScoreLabel";
            this.Team1ScoreLabel.Size = new System.Drawing.Size(135, 23);
            this.Team1ScoreLabel.TabIndex = 7;
            this.Team1ScoreLabel.Text = "<Team 1 Score>";
            // 
            // Team1ScoretextBox
            // 
            this.Team1ScoretextBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Team1ScoretextBox.Location = new System.Drawing.Point(520, 212);
            this.Team1ScoretextBox.Name = "Team1ScoretextBox";
            this.Team1ScoretextBox.Size = new System.Drawing.Size(81, 29);
            this.Team1ScoretextBox.TabIndex = 8;
            this.Team1ScoretextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Team2ScoretextBox
            // 
            this.Team2ScoretextBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Team2ScoretextBox.Location = new System.Drawing.Point(520, 338);
            this.Team2ScoretextBox.Name = "Team2ScoretextBox";
            this.Team2ScoretextBox.Size = new System.Drawing.Size(81, 29);
            this.Team2ScoretextBox.TabIndex = 11;
            this.Team2ScoretextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // Team2ScoreLabel
            // 
            this.Team2ScoreLabel.AutoSize = true;
            this.Team2ScoreLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Team2ScoreLabel.Location = new System.Drawing.Point(379, 344);
            this.Team2ScoreLabel.Name = "Team2ScoreLabel";
            this.Team2ScoreLabel.Size = new System.Drawing.Size(135, 23);
            this.Team2ScoreLabel.TabIndex = 10;
            this.Team2ScoreLabel.Text = "<Team 2 Score>";
            this.Team2ScoreLabel.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // Team2Label
            // 
            this.Team2Label.AutoSize = true;
            this.Team2Label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Team2Label.Location = new System.Drawing.Point(379, 307);
            this.Team2Label.Name = "Team2Label";
            this.Team2Label.Size = new System.Drawing.Size(101, 28);
            this.Team2Label.TabIndex = 9;
            this.Team2Label.Text = "<Team 2>";
            this.Team2Label.Click += new System.EventHandler(this.label2_Click);
            // 
            // VsLabel
            // 
            this.VsLabel.AutoSize = true;
            this.VsLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.VsLabel.Location = new System.Drawing.Point(467, 261);
            this.VsLabel.Name = "VsLabel";
            this.VsLabel.Size = new System.Drawing.Size(47, 28);
            this.VsLabel.TabIndex = 12;
            this.VsLabel.Text = "-Vs-";
            // 
            // ScoreBtn
            // 
            this.ScoreBtn.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.ScoreBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.ScoreBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MintCream;
            this.ScoreBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ScoreBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ScoreBtn.Location = new System.Drawing.Point(621, 261);
            this.ScoreBtn.Name = "ScoreBtn";
            this.ScoreBtn.Size = new System.Drawing.Size(98, 37);
            this.ScoreBtn.TabIndex = 13;
            this.ScoreBtn.Text = "Score";
            this.ScoreBtn.UseVisualStyleBackColor = true;
            this.ScoreBtn.Click += new System.EventHandler(this.ScoreBtn_Click);
            // 
            // TournamentViewrForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(741, 422);
            this.Controls.Add(this.ScoreBtn);
            this.Controls.Add(this.VsLabel);
            this.Controls.Add(this.Team2ScoretextBox);
            this.Controls.Add(this.Team2ScoreLabel);
            this.Controls.Add(this.Team2Label);
            this.Controls.Add(this.Team1ScoretextBox);
            this.Controls.Add(this.Team1ScoreLabel);
            this.Controls.Add(this.Team1Label);
            this.Controls.Add(this.MatchupListBox);
            this.Controls.Add(this.UnplayedCheck);
            this.Controls.Add(this.RoundDropDown);
            this.Controls.Add(this.RoundLabel);
            this.Controls.Add(this.TournamentName);
            this.Controls.Add(this.headerLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.Teal;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "TournamentViewrForm";
            this.Text = "Tournament Viewer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Label TournamentName;
        private System.Windows.Forms.Label RoundLabel;
        private System.Windows.Forms.ComboBox RoundDropDown;
        private System.Windows.Forms.CheckBox UnplayedCheck;
        private System.Windows.Forms.ListBox MatchupListBox;
        private System.Windows.Forms.Label Team1Label;
        private System.Windows.Forms.Label Team1ScoreLabel;
        private System.Windows.Forms.TextBox Team1ScoretextBox;
        private System.Windows.Forms.TextBox Team2ScoretextBox;
        private System.Windows.Forms.Label Team2ScoreLabel;
        private System.Windows.Forms.Label Team2Label;
        private System.Windows.Forms.Label VsLabel;
        private System.Windows.Forms.Button ScoreBtn;
    }
}


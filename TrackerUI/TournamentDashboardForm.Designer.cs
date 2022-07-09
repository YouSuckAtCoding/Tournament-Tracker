
namespace TrackerUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TournamentDashboardForm));
            this.TournamentDashboardheaderLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SelectExistingTournamentDropDown = new System.Windows.Forms.ComboBox();
            this.LoadTournamentBtn = new System.Windows.Forms.Button();
            this.CreateTournamentBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TournamentDashboardheaderLabel
            // 
            this.TournamentDashboardheaderLabel.AutoSize = true;
            this.TournamentDashboardheaderLabel.Location = new System.Drawing.Point(89, 70);
            this.TournamentDashboardheaderLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.TournamentDashboardheaderLabel.Name = "TournamentDashboardheaderLabel";
            this.TournamentDashboardheaderLabel.Size = new System.Drawing.Size(295, 37);
            this.TournamentDashboardheaderLabel.TabIndex = 4;
            this.TournamentDashboardheaderLabel.Text = "Tournament Dashboard";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(104, 135);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 28);
            this.label1.TabIndex = 5;
            this.label1.Text = "Loading Existing Tournament";
            // 
            // SelectExistingTournamentDropDown
            // 
            this.SelectExistingTournamentDropDown.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SelectExistingTournamentDropDown.FormattingEnabled = true;
            this.SelectExistingTournamentDropDown.IntegralHeight = false;
            this.SelectExistingTournamentDropDown.ItemHeight = 20;
            this.SelectExistingTournamentDropDown.Location = new System.Drawing.Point(103, 183);
            this.SelectExistingTournamentDropDown.Name = "SelectExistingTournamentDropDown";
            this.SelectExistingTournamentDropDown.Size = new System.Drawing.Size(266, 28);
            this.SelectExistingTournamentDropDown.TabIndex = 18;
            // 
            // LoadTournamentBtn
            // 
            this.LoadTournamentBtn.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.LoadTournamentBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.LoadTournamentBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MintCream;
            this.LoadTournamentBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoadTournamentBtn.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LoadTournamentBtn.Location = new System.Drawing.Point(160, 238);
            this.LoadTournamentBtn.Name = "LoadTournamentBtn";
            this.LoadTournamentBtn.Size = new System.Drawing.Size(153, 47);
            this.LoadTournamentBtn.TabIndex = 34;
            this.LoadTournamentBtn.Text = "Load Tournament";
            this.LoadTournamentBtn.UseVisualStyleBackColor = true;
            // 
            // CreateTournamentBtn
            // 
            this.CreateTournamentBtn.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.CreateTournamentBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.CreateTournamentBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MintCream;
            this.CreateTournamentBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateTournamentBtn.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CreateTournamentBtn.Location = new System.Drawing.Point(95, 320);
            this.CreateTournamentBtn.Name = "CreateTournamentBtn";
            this.CreateTournamentBtn.Size = new System.Drawing.Size(283, 85);
            this.CreateTournamentBtn.TabIndex = 35;
            this.CreateTournamentBtn.Text = "Create Tournament";
            this.CreateTournamentBtn.UseVisualStyleBackColor = true;
            // 
            // TournamentDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(548, 513);
            this.Controls.Add(this.CreateTournamentBtn);
            this.Controls.Add(this.LoadTournamentBtn);
            this.Controls.Add(this.SelectExistingTournamentDropDown);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TournamentDashboardheaderLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.Teal;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "TournamentDashboardForm";
            this.Text = "TournamentDashboardForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TournamentDashboardheaderLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox SelectExistingTournamentDropDown;
        private System.Windows.Forms.Button LoadTournamentBtn;
        private System.Windows.Forms.Button CreateTournamentBtn;
    }
}
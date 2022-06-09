
namespace DuelSysApp.TournamentForms
{
    partial class fmScoreTournament
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
            this.pCalender = new System.Windows.Forms.Panel();
            this.lbTournament = new System.Windows.Forms.Label();
            this.btnCalculatePoints = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pCalender
            // 
            this.pCalender.Location = new System.Drawing.Point(12, 79);
            this.pCalender.Name = "pCalender";
            this.pCalender.Size = new System.Drawing.Size(901, 442);
            this.pCalender.TabIndex = 9;
            // 
            // lbTournament
            // 
            this.lbTournament.AutoSize = true;
            this.lbTournament.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbTournament.Location = new System.Drawing.Point(369, 19);
            this.lbTournament.Name = "lbTournament";
            this.lbTournament.Size = new System.Drawing.Size(115, 25);
            this.lbTournament.TabIndex = 10;
            this.lbTournament.Text = "Tournament";
            // 
            // btnCalculatePoints
            // 
            this.btnCalculatePoints.Location = new System.Drawing.Point(12, 544);
            this.btnCalculatePoints.Name = "btnCalculatePoints";
            this.btnCalculatePoints.Size = new System.Drawing.Size(901, 38);
            this.btnCalculatePoints.TabIndex = 11;
            this.btnCalculatePoints.Text = "Calculate Points";
            this.btnCalculatePoints.UseVisualStyleBackColor = true;
            this.btnCalculatePoints.Click += new System.EventHandler(this.btnCalculatePoints_Click);
            // 
            // fmScoreTournament
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 594);
            this.Controls.Add(this.btnCalculatePoints);
            this.Controls.Add(this.lbTournament);
            this.Controls.Add(this.pCalender);
            this.Name = "fmScoreTournament";
            this.Text = "ScoreTournament";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pCalender;
        private System.Windows.Forms.Label lbTournament;
        private System.Windows.Forms.Button btnCalculatePoints;
    }
}
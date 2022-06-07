
namespace DuelSysApp.TournamentForms
{
    partial class fmScoreRound
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
            this.lbRound = new System.Windows.Forms.Label();
            this.lbPlayer2 = new System.Windows.Forms.Label();
            this.lbPlayer1 = new System.Windows.Forms.Label();
            this.cmbMatches = new System.Windows.Forms.ComboBox();
            this.tbPlayer1 = new System.Windows.Forms.TextBox();
            this.tbPlayer2 = new System.Windows.Forms.TextBox();
            this.btnMatch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbRound
            // 
            this.lbRound.AutoSize = true;
            this.lbRound.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbRound.Location = new System.Drawing.Point(100, 41);
            this.lbRound.Name = "lbRound";
            this.lbRound.Size = new System.Drawing.Size(73, 25);
            this.lbRound.TabIndex = 0;
            this.lbRound.Text = "Round:";
            // 
            // lbPlayer2
            // 
            this.lbPlayer2.AutoSize = true;
            this.lbPlayer2.Location = new System.Drawing.Point(72, 293);
            this.lbPlayer2.Name = "lbPlayer2";
            this.lbPlayer2.Size = new System.Drawing.Size(64, 20);
            this.lbPlayer2.TabIndex = 1;
            this.lbPlayer2.Text = "Player 2:";
            // 
            // lbPlayer1
            // 
            this.lbPlayer1.AutoSize = true;
            this.lbPlayer1.Location = new System.Drawing.Point(72, 218);
            this.lbPlayer1.Name = "lbPlayer1";
            this.lbPlayer1.Size = new System.Drawing.Size(64, 20);
            this.lbPlayer1.TabIndex = 2;
            this.lbPlayer1.Text = "Player 1:";
            // 
            // cmbMatches
            // 
            this.cmbMatches.FormattingEnabled = true;
            this.cmbMatches.Location = new System.Drawing.Point(72, 172);
            this.cmbMatches.Name = "cmbMatches";
            this.cmbMatches.Size = new System.Drawing.Size(169, 28);
            this.cmbMatches.TabIndex = 3;
            this.cmbMatches.SelectedIndexChanged += new System.EventHandler(this.cmbMatches_SelectedIndexChanged);
            // 
            // tbPlayer1
            // 
            this.tbPlayer1.Location = new System.Drawing.Point(72, 241);
            this.tbPlayer1.Name = "tbPlayer1";
            this.tbPlayer1.Size = new System.Drawing.Size(169, 27);
            this.tbPlayer1.TabIndex = 4;
            // 
            // tbPlayer2
            // 
            this.tbPlayer2.Location = new System.Drawing.Point(72, 316);
            this.tbPlayer2.Name = "tbPlayer2";
            this.tbPlayer2.Size = new System.Drawing.Size(169, 27);
            this.tbPlayer2.TabIndex = 5;
            // 
            // btnMatch
            // 
            this.btnMatch.Location = new System.Drawing.Point(52, 384);
            this.btnMatch.Name = "btnMatch";
            this.btnMatch.Size = new System.Drawing.Size(215, 42);
            this.btnMatch.TabIndex = 6;
            this.btnMatch.Text = "DONE";
            this.btnMatch.UseVisualStyleBackColor = true;
            this.btnMatch.Click += new System.EventHandler(this.btnMatch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "MATCH:";
            // 
            // fmScoreRound
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMatch);
            this.Controls.Add(this.tbPlayer2);
            this.Controls.Add(this.tbPlayer1);
            this.Controls.Add(this.cmbMatches);
            this.Controls.Add(this.lbPlayer1);
            this.Controls.Add(this.lbPlayer2);
            this.Controls.Add(this.lbRound);
            this.Name = "fmScoreRound";
            this.Text = "ScoreRound";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbRound;
        private System.Windows.Forms.Label lbPlayer2;
        private System.Windows.Forms.Label lbPlayer1;
        private System.Windows.Forms.ComboBox cmbMatches;
        private System.Windows.Forms.TextBox tbPlayer1;
        private System.Windows.Forms.TextBox tbPlayer2;
        private System.Windows.Forms.Button btnMatch;
        private System.Windows.Forms.Label label1;
    }
}
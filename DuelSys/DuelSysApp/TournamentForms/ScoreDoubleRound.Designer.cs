
namespace DuelSysApp.TournamentForms
{
    partial class fmScoreDoubleRound
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnMatch = new System.Windows.Forms.Button();
            this.tbPlayer2Match1 = new System.Windows.Forms.TextBox();
            this.tbPlayer1Match1 = new System.Windows.Forms.TextBox();
            this.cmbMatches = new System.Windows.Forms.ComboBox();
            this.lbPlayer1Match1 = new System.Windows.Forms.Label();
            this.lbPlayer2Match1 = new System.Windows.Forms.Label();
            this.lbRound = new System.Windows.Forms.Label();
            this.tbPlayer2Match2 = new System.Windows.Forms.TextBox();
            this.tbPlayer1Match2 = new System.Windows.Forms.TextBox();
            this.lbPlayer1Match2 = new System.Windows.Forms.Label();
            this.lbPlayer2Match2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "MATCH:";
            // 
            // btnMatch
            // 
            this.btnMatch.Location = new System.Drawing.Point(42, 467);
            this.btnMatch.Name = "btnMatch";
            this.btnMatch.Size = new System.Drawing.Size(215, 42);
            this.btnMatch.TabIndex = 14;
            this.btnMatch.Text = "DONE";
            this.btnMatch.UseVisualStyleBackColor = true;
            this.btnMatch.Click += new System.EventHandler(this.btnMatch_Click);
            // 
            // tbPlayer2Match1
            // 
            this.tbPlayer2Match1.Location = new System.Drawing.Point(61, 253);
            this.tbPlayer2Match1.Name = "tbPlayer2Match1";
            this.tbPlayer2Match1.Size = new System.Drawing.Size(169, 27);
            this.tbPlayer2Match1.TabIndex = 13;
            // 
            // tbPlayer1Match1
            // 
            this.tbPlayer1Match1.Location = new System.Drawing.Point(61, 178);
            this.tbPlayer1Match1.Name = "tbPlayer1Match1";
            this.tbPlayer1Match1.Size = new System.Drawing.Size(169, 27);
            this.tbPlayer1Match1.TabIndex = 12;
            // 
            // cmbMatches
            // 
            this.cmbMatches.FormattingEnabled = true;
            this.cmbMatches.Location = new System.Drawing.Point(61, 109);
            this.cmbMatches.Name = "cmbMatches";
            this.cmbMatches.Size = new System.Drawing.Size(169, 28);
            this.cmbMatches.TabIndex = 11;
            this.cmbMatches.SelectedIndexChanged += new System.EventHandler(this.cmbMatches_SelectedIndexChanged);
            // 
            // lbPlayer1Match1
            // 
            this.lbPlayer1Match1.AutoSize = true;
            this.lbPlayer1Match1.Location = new System.Drawing.Point(61, 155);
            this.lbPlayer1Match1.Name = "lbPlayer1Match1";
            this.lbPlayer1Match1.Size = new System.Drawing.Size(64, 20);
            this.lbPlayer1Match1.TabIndex = 10;
            this.lbPlayer1Match1.Text = "Player 1:";
            // 
            // lbPlayer2Match1
            // 
            this.lbPlayer2Match1.AutoSize = true;
            this.lbPlayer2Match1.Location = new System.Drawing.Point(61, 230);
            this.lbPlayer2Match1.Name = "lbPlayer2Match1";
            this.lbPlayer2Match1.Size = new System.Drawing.Size(64, 20);
            this.lbPlayer2Match1.TabIndex = 9;
            this.lbPlayer2Match1.Text = "Player 2:";
            // 
            // lbRound
            // 
            this.lbRound.AutoSize = true;
            this.lbRound.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbRound.Location = new System.Drawing.Point(102, 32);
            this.lbRound.Name = "lbRound";
            this.lbRound.Size = new System.Drawing.Size(73, 25);
            this.lbRound.TabIndex = 8;
            this.lbRound.Text = "Round:";
            // 
            // tbPlayer2Match2
            // 
            this.tbPlayer2Match2.Location = new System.Drawing.Point(61, 386);
            this.tbPlayer2Match2.Name = "tbPlayer2Match2";
            this.tbPlayer2Match2.Size = new System.Drawing.Size(169, 27);
            this.tbPlayer2Match2.TabIndex = 19;
            // 
            // tbPlayer1Match2
            // 
            this.tbPlayer1Match2.Location = new System.Drawing.Point(61, 311);
            this.tbPlayer1Match2.Name = "tbPlayer1Match2";
            this.tbPlayer1Match2.Size = new System.Drawing.Size(169, 27);
            this.tbPlayer1Match2.TabIndex = 18;
            // 
            // lbPlayer1Match2
            // 
            this.lbPlayer1Match2.AutoSize = true;
            this.lbPlayer1Match2.Location = new System.Drawing.Point(61, 288);
            this.lbPlayer1Match2.Name = "lbPlayer1Match2";
            this.lbPlayer1Match2.Size = new System.Drawing.Size(64, 20);
            this.lbPlayer1Match2.TabIndex = 17;
            this.lbPlayer1Match2.Text = "Player 1:";
            // 
            // lbPlayer2Match2
            // 
            this.lbPlayer2Match2.AutoSize = true;
            this.lbPlayer2Match2.Location = new System.Drawing.Point(61, 363);
            this.lbPlayer2Match2.Name = "lbPlayer2Match2";
            this.lbPlayer2Match2.Size = new System.Drawing.Size(64, 20);
            this.lbPlayer2Match2.TabIndex = 16;
            this.lbPlayer2Match2.Text = "Player 2:";
            // 
            // fmScoreDoubleRound
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 530);
            this.Controls.Add(this.tbPlayer2Match2);
            this.Controls.Add(this.tbPlayer1Match2);
            this.Controls.Add(this.lbPlayer1Match2);
            this.Controls.Add(this.lbPlayer2Match2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMatch);
            this.Controls.Add(this.tbPlayer2Match1);
            this.Controls.Add(this.tbPlayer1Match1);
            this.Controls.Add(this.cmbMatches);
            this.Controls.Add(this.lbPlayer1Match1);
            this.Controls.Add(this.lbPlayer2Match1);
            this.Controls.Add(this.lbRound);
            this.Name = "fmScoreDoubleRound";
            this.Text = "ScoreDoubleRound";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMatch;
        private System.Windows.Forms.TextBox tbPlayer2Match1;
        private System.Windows.Forms.TextBox tbPlayer1Match1;
        private System.Windows.Forms.ComboBox cmbMatches;
        private System.Windows.Forms.Label lbPlayer1Match1;
        private System.Windows.Forms.Label lbPlayer2Match1;
        private System.Windows.Forms.Label lbRound;
        private System.Windows.Forms.TextBox tbPlayer2Match2;
        private System.Windows.Forms.TextBox tbPlayer1Match2;
        private System.Windows.Forms.Label lbPlayer1Match2;
        private System.Windows.Forms.Label lbPlayer2Match2;
    }
}
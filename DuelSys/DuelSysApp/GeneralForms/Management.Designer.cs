
namespace DuelSysApp.GeneralForms
{
    partial class fmManagement
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.btnLogOutStaff = new System.Windows.Forms.Button();
            this.lbWelcome = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDeleteStaff = new System.Windows.Forms.Button();
            this.btnUpdateStaff = new System.Windows.Forms.Button();
            this.btnAddStaff = new System.Windows.Forms.Button();
            this.dtgvStaff = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnScoreTournament = new System.Windows.Forms.Button();
            this.btnLogOutTournament = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnGenerateTournament = new System.Windows.Forms.Button();
            this.btnDeleteTournament = new System.Windows.Forms.Button();
            this.btnUpdateTournament = new System.Windows.Forms.Button();
            this.btnAddTournament = new System.Windows.Forms.Button();
            this.dtgvTournament = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvStaff)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTournament)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(14, 16);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(887, 568);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.btnLogOutStaff);
            this.tabPage1.Controls.Add(this.lbWelcome);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.dtgvStaff);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Size = new System.Drawing.Size(879, 535);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Staff";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(525, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 7;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnLogOutStaff
            // 
            this.btnLogOutStaff.Location = new System.Drawing.Point(779, 487);
            this.btnLogOutStaff.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLogOutStaff.Name = "btnLogOutStaff";
            this.btnLogOutStaff.Size = new System.Drawing.Size(98, 44);
            this.btnLogOutStaff.TabIndex = 6;
            this.btnLogOutStaff.Text = "Log Out";
            this.btnLogOutStaff.UseVisualStyleBackColor = true;
            this.btnLogOutStaff.Click += new System.EventHandler(this.btnLogOutStaff_Click);
            // 
            // lbWelcome
            // 
            this.lbWelcome.AutoSize = true;
            this.lbWelcome.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbWelcome.ForeColor = System.Drawing.Color.Turquoise;
            this.lbWelcome.Location = new System.Drawing.Point(242, 37);
            this.lbWelcome.Name = "lbWelcome";
            this.lbWelcome.Size = new System.Drawing.Size(63, 25);
            this.lbWelcome.TabIndex = 5;
            this.lbWelcome.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(93, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 28);
            this.label1.TabIndex = 4;
            this.label1.Text = "Welcome back";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDeleteStaff);
            this.groupBox1.Controls.Add(this.btnUpdateStaff);
            this.groupBox1.Controls.Add(this.btnAddStaff);
            this.groupBox1.Location = new System.Drawing.Point(570, 95);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(258, 329);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Commands:";
            // 
            // btnDeleteStaff
            // 
            this.btnDeleteStaff.Location = new System.Drawing.Point(37, 235);
            this.btnDeleteStaff.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDeleteStaff.Name = "btnDeleteStaff";
            this.btnDeleteStaff.Size = new System.Drawing.Size(153, 56);
            this.btnDeleteStaff.TabIndex = 2;
            this.btnDeleteStaff.Text = "DELETE";
            this.btnDeleteStaff.UseVisualStyleBackColor = true;
            this.btnDeleteStaff.Click += new System.EventHandler(this.btnDeleteStaff_Click);
            // 
            // btnUpdateStaff
            // 
            this.btnUpdateStaff.Location = new System.Drawing.Point(37, 156);
            this.btnUpdateStaff.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUpdateStaff.Name = "btnUpdateStaff";
            this.btnUpdateStaff.Size = new System.Drawing.Size(153, 56);
            this.btnUpdateStaff.TabIndex = 1;
            this.btnUpdateStaff.Text = "UPDATE";
            this.btnUpdateStaff.UseVisualStyleBackColor = true;
            this.btnUpdateStaff.Click += new System.EventHandler(this.btnUpdateStaff_Click);
            // 
            // btnAddStaff
            // 
            this.btnAddStaff.Location = new System.Drawing.Point(37, 77);
            this.btnAddStaff.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddStaff.Name = "btnAddStaff";
            this.btnAddStaff.Size = new System.Drawing.Size(153, 56);
            this.btnAddStaff.TabIndex = 0;
            this.btnAddStaff.Text = "ADD";
            this.btnAddStaff.UseVisualStyleBackColor = true;
            this.btnAddStaff.Click += new System.EventHandler(this.btnAddStaff_Click);
            // 
            // dtgvStaff
            // 
            this.dtgvStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvStaff.Location = new System.Drawing.Point(7, 95);
            this.dtgvStaff.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtgvStaff.Name = "dtgvStaff";
            this.dtgvStaff.RowHeadersWidth = 51;
            this.dtgvStaff.RowTemplate.Height = 25;
            this.dtgvStaff.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvStaff.Size = new System.Drawing.Size(557, 329);
            this.dtgvStaff.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnScoreTournament);
            this.tabPage2.Controls.Add(this.btnLogOutTournament);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.dtgvTournament);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Size = new System.Drawing.Size(879, 535);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Tournament";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnScoreTournament
            // 
            this.btnScoreTournament.Location = new System.Drawing.Point(7, 429);
            this.btnScoreTournament.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnScoreTournament.Name = "btnScoreTournament";
            this.btnScoreTournament.Size = new System.Drawing.Size(557, 56);
            this.btnScoreTournament.TabIndex = 8;
            this.btnScoreTournament.Text = "SCORE THE TOURNAMENT";
            this.btnScoreTournament.UseVisualStyleBackColor = true;
            this.btnScoreTournament.Click += new System.EventHandler(this.btnScoreTournament_Click);
            // 
            // btnLogOutTournament
            // 
            this.btnLogOutTournament.Location = new System.Drawing.Point(779, 487);
            this.btnLogOutTournament.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLogOutTournament.Name = "btnLogOutTournament";
            this.btnLogOutTournament.Size = new System.Drawing.Size(98, 44);
            this.btnLogOutTournament.TabIndex = 7;
            this.btnLogOutTournament.Text = "Log Out";
            this.btnLogOutTournament.UseVisualStyleBackColor = true;
            this.btnLogOutTournament.Click += new System.EventHandler(this.btnLogOutTournament_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnGenerateTournament);
            this.groupBox2.Controls.Add(this.btnDeleteTournament);
            this.groupBox2.Controls.Add(this.btnUpdateTournament);
            this.groupBox2.Controls.Add(this.btnAddTournament);
            this.groupBox2.Location = new System.Drawing.Point(581, 76);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(258, 329);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Commands:";
            // 
            // btnGenerateTournament
            // 
            this.btnGenerateTournament.Location = new System.Drawing.Point(50, 255);
            this.btnGenerateTournament.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGenerateTournament.Name = "btnGenerateTournament";
            this.btnGenerateTournament.Size = new System.Drawing.Size(153, 56);
            this.btnGenerateTournament.TabIndex = 3;
            this.btnGenerateTournament.Text = "GENERATE TOURNAMENT";
            this.btnGenerateTournament.UseVisualStyleBackColor = true;
            // 
            // btnDeleteTournament
            // 
            this.btnDeleteTournament.Location = new System.Drawing.Point(50, 181);
            this.btnDeleteTournament.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDeleteTournament.Name = "btnDeleteTournament";
            this.btnDeleteTournament.Size = new System.Drawing.Size(153, 56);
            this.btnDeleteTournament.TabIndex = 2;
            this.btnDeleteTournament.Text = "DELETE";
            this.btnDeleteTournament.UseVisualStyleBackColor = true;
            this.btnDeleteTournament.Click += new System.EventHandler(this.btnDeleteTournament_Click);
            // 
            // btnUpdateTournament
            // 
            this.btnUpdateTournament.Location = new System.Drawing.Point(50, 102);
            this.btnUpdateTournament.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUpdateTournament.Name = "btnUpdateTournament";
            this.btnUpdateTournament.Size = new System.Drawing.Size(153, 56);
            this.btnUpdateTournament.TabIndex = 1;
            this.btnUpdateTournament.Text = "UPDATE";
            this.btnUpdateTournament.UseVisualStyleBackColor = true;
            this.btnUpdateTournament.Click += new System.EventHandler(this.btnUpdateTournament_Click);
            // 
            // btnAddTournament
            // 
            this.btnAddTournament.Location = new System.Drawing.Point(50, 23);
            this.btnAddTournament.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddTournament.Name = "btnAddTournament";
            this.btnAddTournament.Size = new System.Drawing.Size(153, 56);
            this.btnAddTournament.TabIndex = 0;
            this.btnAddTournament.Text = "ADD";
            this.btnAddTournament.UseVisualStyleBackColor = true;
            this.btnAddTournament.Click += new System.EventHandler(this.btnAddTournament_Click);
            // 
            // dtgvTournament
            // 
            this.dtgvTournament.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvTournament.Location = new System.Drawing.Point(7, 76);
            this.dtgvTournament.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtgvTournament.Name = "dtgvTournament";
            this.dtgvTournament.RowHeadersWidth = 51;
            this.dtgvTournament.RowTemplate.Height = 25;
            this.dtgvTournament.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvTournament.Size = new System.Drawing.Size(557, 329);
            this.dtgvTournament.TabIndex = 1;
            // 
            // fmManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "fmManagement";
            this.Text = "Management";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvStaff)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTournament)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDeleteStaff;
        private System.Windows.Forms.Button btnUpdateStaff;
        private System.Windows.Forms.Button btnAddStaff;
        private System.Windows.Forms.DataGridView dtgvStaff;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDeleteTournament;
        private System.Windows.Forms.Button btnUpdateTournament;
        private System.Windows.Forms.Button btnAddTournament;
        private System.Windows.Forms.DataGridView dtgvTournament;
        private System.Windows.Forms.Label lbWelcome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLogOutStaff;
        private System.Windows.Forms.Button btnLogOutTournament;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnScoreTournament;
        private System.Windows.Forms.Button btnGenerateTournament;
    }
}
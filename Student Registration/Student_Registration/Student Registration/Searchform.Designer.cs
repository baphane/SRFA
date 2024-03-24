namespace Student_Registration
{
    partial class Searchform
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
            this.grpSearch = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtStudentSerch = new System.Windows.Forms.TextBox();
            this.lblSudentIDUpdate = new System.Windows.Forms.Label();
            this.grpSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // grpSearch
            // 
            this.grpSearch.Controls.Add(this.dataGridView1);
            this.grpSearch.Controls.Add(this.btnSearch);
            this.grpSearch.Controls.Add(this.txtStudentSerch);
            this.grpSearch.Controls.Add(this.lblSudentIDUpdate);
            this.grpSearch.Location = new System.Drawing.Point(29, 28);
            this.grpSearch.Name = "grpSearch";
            this.grpSearch.Size = new System.Drawing.Size(368, 148);
            this.grpSearch.TabIndex = 2;
            this.grpSearch.TabStop = false;
            this.grpSearch.Text = "Search";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(25, 47);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(323, 95);
            this.dataGridView1.TabIndex = 12;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(246, 18);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtStudentSerch
            // 
            this.txtStudentSerch.Location = new System.Drawing.Point(67, 21);
            this.txtStudentSerch.Name = "txtStudentSerch";
            this.txtStudentSerch.Size = new System.Drawing.Size(100, 20);
            this.txtStudentSerch.TabIndex = 11;
            // 
            // lblSudentIDUpdate
            // 
            this.lblSudentIDUpdate.AutoSize = true;
            this.lblSudentIDUpdate.Location = new System.Drawing.Point(6, 24);
            this.lblSudentIDUpdate.Name = "lblSudentIDUpdate";
            this.lblSudentIDUpdate.Size = new System.Drawing.Size(55, 13);
            this.lblSudentIDUpdate.TabIndex = 6;
            this.lblSudentIDUpdate.Text = "StudentID";
            // 
            // Searchform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(507, 227);
            this.Controls.Add(this.grpSearch);
            this.Name = "Searchform";
            this.Text = "Searchform";
            this.grpSearch.ResumeLayout(false);
            this.grpSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpSearch;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtStudentSerch;
        private System.Windows.Forms.Label lblSudentIDUpdate;
    }
}
namespace Student_Registration
{
    partial class Deleteform
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
            this.grpUpdate = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnDeleteform = new System.Windows.Forms.Button();
            this.txtStudentDelete = new System.Windows.Forms.TextBox();
            this.lblSudentIDUpdate = new System.Windows.Forms.Label();
            this.grpUpdate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // grpUpdate
            // 
            this.grpUpdate.Controls.Add(this.dataGridView1);
            this.grpUpdate.Controls.Add(this.btnDeleteform);
            this.grpUpdate.Controls.Add(this.txtStudentDelete);
            this.grpUpdate.Controls.Add(this.lblSudentIDUpdate);
            this.grpUpdate.Location = new System.Drawing.Point(24, 12);
            this.grpUpdate.Name = "grpUpdate";
            this.grpUpdate.Size = new System.Drawing.Size(368, 180);
            this.grpUpdate.TabIndex = 2;
            this.grpUpdate.TabStop = false;
            this.grpUpdate.Text = "Delete";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(22, 60);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(323, 95);
            this.dataGridView1.TabIndex = 12;
            // 
            // btnDeleteform
            // 
            this.btnDeleteform.Location = new System.Drawing.Point(270, 18);
            this.btnDeleteform.Name = "btnDeleteform";
            this.btnDeleteform.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteform.TabIndex = 10;
            this.btnDeleteform.Text = "Delete";
            this.btnDeleteform.UseVisualStyleBackColor = true;
            this.btnDeleteform.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtStudentDelete
            // 
            this.txtStudentDelete.Location = new System.Drawing.Point(67, 21);
            this.txtStudentDelete.Name = "txtStudentDelete";
            this.txtStudentDelete.Size = new System.Drawing.Size(197, 20);
            this.txtStudentDelete.TabIndex = 11;
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
            // Deleteform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(444, 189);
            this.Controls.Add(this.grpUpdate);
            this.Name = "Deleteform";
            this.Text = "Deleteform";
            this.grpUpdate.ResumeLayout(false);
            this.grpUpdate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpUpdate;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnDeleteform;
        private System.Windows.Forms.TextBox txtStudentDelete;
        private System.Windows.Forms.Label lblSudentIDUpdate;
    }
}
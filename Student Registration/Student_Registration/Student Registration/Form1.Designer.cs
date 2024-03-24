namespace Student_Registration
{
    partial class Form1
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
            this.grpCreate = new System.Windows.Forms.GroupBox();
            this.txtcoursecode = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblCourseCode = new System.Windows.Forms.Label();
            this.lblAdress = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblPhone = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtAdress = new System.Windows.Forms.TextBox();
            this.lblsurname = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.cboGender = new System.Windows.Forms.ComboBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblDOB = new System.Windows.Forms.Label();
            this.txtStdentID = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.lblStudentID = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.grpRead = new System.Windows.Forms.GroupBox();
            this.dgvRead = new System.Windows.Forms.DataGridView();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.grpCreate.SuspendLayout();
            this.grpRead.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRead)).BeginInit();
            this.SuspendLayout();
            // 
            // grpCreate
            // 
            this.grpCreate.Controls.Add(this.txtcoursecode);
            this.grpCreate.Controls.Add(this.btnExit);
            this.grpCreate.Controls.Add(this.lblCourseCode);
            this.grpCreate.Controls.Add(this.lblAdress);
            this.grpCreate.Controls.Add(this.btnUpdate);
            this.grpCreate.Controls.Add(this.lblPhone);
            this.grpCreate.Controls.Add(this.dateTimePicker1);
            this.grpCreate.Controls.Add(this.txtPhoneNumber);
            this.grpCreate.Controls.Add(this.txtAdress);
            this.grpCreate.Controls.Add(this.lblsurname);
            this.grpCreate.Controls.Add(this.txtSurname);
            this.grpCreate.Controls.Add(this.cboGender);
            this.grpCreate.Controls.Add(this.lblGender);
            this.grpCreate.Controls.Add(this.lblDOB);
            this.grpCreate.Controls.Add(this.txtStdentID);
            this.grpCreate.Controls.Add(this.txtname);
            this.grpCreate.Controls.Add(this.lblStudentID);
            this.grpCreate.Controls.Add(this.lblName);
            this.grpCreate.Controls.Add(this.btnRegister);
            this.grpCreate.Location = new System.Drawing.Point(13, 13);
            this.grpCreate.Margin = new System.Windows.Forms.Padding(4);
            this.grpCreate.Name = "grpCreate";
            this.grpCreate.Padding = new System.Windows.Forms.Padding(4);
            this.grpCreate.Size = new System.Drawing.Size(500, 372);
            this.grpCreate.TabIndex = 0;
            this.grpCreate.TabStop = false;
            this.grpCreate.Text = "Creating";
            // 
            // txtcoursecode
            // 
            this.txtcoursecode.Location = new System.Drawing.Point(197, 278);
            this.txtcoursecode.Margin = new System.Windows.Forms.Padding(4);
            this.txtcoursecode.Name = "txtcoursecode";
            this.txtcoursecode.Size = new System.Drawing.Size(132, 22);
            this.txtcoursecode.TabIndex = 7;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(349, 325);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(117, 39);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblCourseCode
            // 
            this.lblCourseCode.AutoSize = true;
            this.lblCourseCode.Location = new System.Drawing.Point(55, 292);
            this.lblCourseCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCourseCode.Name = "lblCourseCode";
            this.lblCourseCode.Size = new System.Drawing.Size(96, 17);
            this.lblCourseCode.TabIndex = 11;
            this.lblCourseCode.Text = "Course CODE";
            // 
            // lblAdress
            // 
            this.lblAdress.AutoSize = true;
            this.lblAdress.Location = new System.Drawing.Point(55, 249);
            this.lblAdress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAdress.Name = "lblAdress";
            this.lblAdress.Size = new System.Drawing.Size(52, 17);
            this.lblAdress.TabIndex = 12;
            this.lblAdress.Text = "Adress";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(59, 325);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 39);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(55, 222);
            this.lblPhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(101, 17);
            this.lblPhone.TabIndex = 13;
            this.lblPhone.Text = "Phone number";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd-MM-yyyy";
            this.dateTimePicker1.Location = new System.Drawing.Point(197, 140);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(132, 22);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(197, 213);
            this.txtPhoneNumber.Margin = new System.Windows.Forms.Padding(4);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(132, 22);
            this.txtPhoneNumber.TabIndex = 5;
            // 
            // txtAdress
            // 
            this.txtAdress.Location = new System.Drawing.Point(197, 245);
            this.txtAdress.Margin = new System.Windows.Forms.Padding(4);
            this.txtAdress.Name = "txtAdress";
            this.txtAdress.Size = new System.Drawing.Size(132, 22);
            this.txtAdress.TabIndex = 6;
            // 
            // lblsurname
            // 
            this.lblsurname.AutoSize = true;
            this.lblsurname.Location = new System.Drawing.Point(55, 98);
            this.lblsurname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblsurname.Name = "lblsurname";
            this.lblsurname.Size = new System.Drawing.Size(65, 17);
            this.lblsurname.TabIndex = 9;
            this.lblsurname.Text = "Surname";
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(197, 98);
            this.txtSurname.Margin = new System.Windows.Forms.Padding(4);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(132, 22);
            this.txtSurname.TabIndex = 2;
            // 
            // cboGender
            // 
            this.cboGender.FormattingEnabled = true;
            this.cboGender.Location = new System.Drawing.Point(197, 172);
            this.cboGender.Margin = new System.Windows.Forms.Padding(4);
            this.cboGender.Name = "cboGender";
            this.cboGender.Size = new System.Drawing.Size(132, 24);
            this.cboGender.TabIndex = 4;
            this.cboGender.SelectedIndexChanged += new System.EventHandler(this.cboGender_SelectedIndexChanged);
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(55, 176);
            this.lblGender.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(56, 17);
            this.lblGender.TabIndex = 4;
            this.lblGender.Text = "Gender";
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Location = new System.Drawing.Point(55, 140);
            this.lblDOB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(38, 17);
            this.lblDOB.TabIndex = 5;
            this.lblDOB.Text = "DOB";
            // 
            // txtStdentID
            // 
            this.txtStdentID.Location = new System.Drawing.Point(197, 22);
            this.txtStdentID.Margin = new System.Windows.Forms.Padding(4);
            this.txtStdentID.Name = "txtStdentID";
            this.txtStdentID.Size = new System.Drawing.Size(132, 22);
            this.txtStdentID.TabIndex = 0;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(197, 54);
            this.txtname.Margin = new System.Windows.Forms.Padding(4);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(132, 22);
            this.txtname.TabIndex = 1;
            // 
            // lblStudentID
            // 
            this.lblStudentID.AutoSize = true;
            this.lblStudentID.Location = new System.Drawing.Point(41, 34);
            this.lblStudentID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStudentID.Name = "lblStudentID";
            this.lblStudentID.Size = new System.Drawing.Size(70, 17);
            this.lblStudentID.TabIndex = 1;
            this.lblStudentID.Text = "StudentID";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(55, 63);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(45, 17);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Name";
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(197, 325);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(100, 39);
            this.btnRegister.TabIndex = 9;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // grpRead
            // 
            this.grpRead.Controls.Add(this.txtSearch);
            this.grpRead.Controls.Add(this.dgvRead);
            this.grpRead.Controls.Add(this.btnDisplay);
            this.grpRead.Controls.Add(this.btnSearch);
            this.grpRead.Location = new System.Drawing.Point(521, 13);
            this.grpRead.Margin = new System.Windows.Forms.Padding(4);
            this.grpRead.Name = "grpRead";
            this.grpRead.Padding = new System.Windows.Forms.Padding(4);
            this.grpRead.Size = new System.Drawing.Size(811, 371);
            this.grpRead.TabIndex = 1;
            this.grpRead.TabStop = false;
            this.grpRead.Text = "Read";
            // 
            // dgvRead
            // 
            this.dgvRead.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRead.Location = new System.Drawing.Point(8, 27);
            this.dgvRead.Margin = new System.Windows.Forms.Padding(4);
            this.dgvRead.Name = "dgvRead";
            this.dgvRead.RowHeadersWidth = 51;
            this.dgvRead.Size = new System.Drawing.Size(795, 268);
            this.dgvRead.TabIndex = 10;
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(8, 320);
            this.btnDisplay.Margin = new System.Windows.Forms.Padding(4);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(297, 43);
            this.btnDisplay.TabIndex = 11;
            this.btnDisplay.Text = "Display";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(553, 330);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(132, 22);
            this.txtSearch.TabIndex = 7;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(703, 320);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 39);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1361, 739);
            this.Controls.Add(this.grpRead);
            this.Controls.Add(this.grpCreate);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Registration form";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpCreate.ResumeLayout(false);
            this.grpCreate.PerformLayout();
            this.grpRead.ResumeLayout(false);
            this.grpRead.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRead)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpCreate;
        private System.Windows.Forms.GroupBox grpRead;
        private System.Windows.Forms.Label lblCourseCode;
        private System.Windows.Forms.Label lblAdress;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.TextBox txtAdress;
        private System.Windows.Forms.Label lblsurname;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.TextBox txtStdentID;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label lblStudentID;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.DataGridView dgvRead;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtcoursecode;
        private System.Windows.Forms.ComboBox cboGender;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
    }
}


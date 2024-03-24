using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Student_Registration
{
    public partial class Login : Form
    {
        private Panel panel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnLogin;
        private Button btnRegister;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private Label lblPassword;
        private Label lblUsername;
        private Label lblLogin;

        string filePath = @"C:\Users\Xx\OneDrive\School\C# Code Space\Student Registration/LoginDetails.txt";

        public Login()
        {
            InitializeComponent();
        }


        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Controls.Add(this.txtUsername);
            this.panel1.Controls.Add(this.lblPassword);
            this.panel1.Controls.Add(this.lblUsername);
            this.panel1.Controls.Add(this.lblLogin);
            this.panel1.Location = new System.Drawing.Point(171, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(433, 283);
            this.panel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnLogin);
            this.flowLayoutPanel1.Controls.Add(this.btnRegister);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(120, 169);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(200, 53);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(3, 3);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(86, 40);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click_1);
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(95, 3);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(86, 40);
            this.btnRegister.TabIndex = 0;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(204, 119);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(100, 22);
            this.txtPassword.TabIndex = 5;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(204, 78);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(100, 22);
            this.txtUsername.TabIndex = 4;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(121, 119);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(77, 17);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Password :";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(117, 81);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(81, 17);
            this.lblUsername.TabIndex = 2;
            this.lblUsername.Text = "Username :";
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.Location = new System.Drawing.Point(161, 16);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(101, 39);
            this.lblLogin.TabIndex = 1;
            this.lblLogin.Text = "Login";
            // 
            // Login
            // 
            this.ClientSize = new System.Drawing.Size(849, 483);
            this.Controls.Add(this.panel1);
            this.Name = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private void Login_Load(object sender, EventArgs e)
        {
            btnRegister.Hide();
            panel1.BackColor = Color.Transparent;
            panel1.BorderStyle = BorderStyle.Fixed3D;

            this.Paint += new PaintEventHandler(Login_Paint);
        }

        private void Login_Paint(object sender, PaintEventArgs e)
        {
            // Define the gradient colors
            Color color1 = Color.FromArgb(229, 217, 255);
            Color color2 = Color.FromArgb(0, 117, 112);

            // Create a vertical gradient brush
            using (System.Drawing.Drawing2D.LinearGradientBrush brush =
                   new System.Drawing.Drawing2D.LinearGradientBrush(this.ClientRectangle, color1, color2,
                   System.Drawing.Drawing2D.LinearGradientMode.Vertical))
            {
                // Fill the form background with the gradient brush
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
        }


        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.");
                return;
            }

            if (IsUsernameAvailable(username))
            {
                RegisterUser(username, password);
                MessageBox.Show("Registration successful. You can now log in.");
            }
            else
            {
                MessageBox.Show("Username already exists. Please choose a different username.");
            }
        }

        private bool AuthenticateUser(string username, string password)
        {
            // Check if the user exists in the login details file
            string[] loginDetails = File.ReadAllLines(filePath);
            foreach (string line in loginDetails)
            {
                string[] details = line.Split(',');
                if (details[0] == username && details[1] == password)
                {
                    return true;
                }
            }

            return false;
        }

        private bool IsUsernameAvailable(string username)
        {
            // Check if the username already exists in the login details file
            string[] loginDetails = File.ReadAllLines(filePath);
            foreach (string line in loginDetails)
            {
                string[] details = line.Split(',');
                if (details[0] == username)
                {
                    return false;
                }
            }

            return true;
        }

        private void RegisterUser(string username, string password)
        {
            // Append the new user's login details to the login details file
            string newLine = $"{username},{password}";
            File.AppendAllText(filePath, newLine + Environment.NewLine);
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.");
                return;
            }

            if (AuthenticateUser(username, password))
            {
                Form1 crudForm = new Form1();
                crudForm.ShowDialog();
                Close();
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
                btnRegister.Show();
            }
        }

        private void btnRegister_MouseHover(object sender, EventArgs e)
        {
            Color startColor = btnRegister.BackColor;
            Color endColor = Color.LightSeaGreen;
            AnimateButtonColor(startColor, endColor);
        }

        private void btnRegister_MouseLeave(object sender, EventArgs e)
        {
            Color startColor = btnRegister.BackColor;
            Color endColor = SystemColors.Control;
            AnimateButtonColor(startColor, endColor);
        }
        private async void AnimateButtonColor(Color startColor, Color endColor)
        {
            for (int i = 0; i <= 10; i++)
            {
                float ratio = (float)i / 10;
                int r = (int)(startColor.R + (endColor.R - startColor.R) * ratio);
                int g = (int)(startColor.G + (endColor.G - startColor.G) * ratio);
                int b = (int)(startColor.B + (endColor.B - startColor.B) * ratio);
                Color transitionColor = Color.FromArgb(r, g, b);
                btnRegister.BackColor = transitionColor;
                await Task.Delay(30);
            }
        }

        private void btnLogin_MouseHover(object sender, EventArgs e)
        {
            Color startColor = btnRegister.BackColor;
            Color endColor = Color.LightSeaGreen;
            AnimateButtonColor(startColor, endColor);
        }

        private void btnLogin_MouseLeave(object sender, EventArgs e)
        {
            Color startColor = btnRegister.BackColor;
            Color endColor = SystemColors.Control;
            AnimateButtonColor(startColor, endColor);
        }
    }
}

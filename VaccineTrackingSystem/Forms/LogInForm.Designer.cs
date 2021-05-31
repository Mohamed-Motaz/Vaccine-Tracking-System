namespace VaccineTrackingSystem
{
    partial class LogInForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogInForm));
            this.LogIn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.LogInPassword = new System.Windows.Forms.TextBox();
            this.SignUp = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LogInNationlID = new System.Windows.Forms.TextBox();
            this.ShowPassword = new System.Windows.Forms.CheckBox();
            this.IsAdmin = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LogIn
            // 
            this.LogIn.BackColor = System.Drawing.Color.Transparent;
            this.LogIn.FlatAppearance.BorderSize = 0;
            this.LogIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogIn.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogIn.ForeColor = System.Drawing.Color.White;
            this.LogIn.Image = ((System.Drawing.Image)(resources.GetObject("LogIn.Image")));
            this.LogIn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LogIn.Location = new System.Drawing.Point(23, 275);
            this.LogIn.Name = "LogIn";
            this.LogIn.Size = new System.Drawing.Size(124, 46);
            this.LogIn.TabIndex = 0;
            this.LogIn.Text = "Log In";
            this.LogIn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LogIn.UseVisualStyleBackColor = false;
            this.LogIn.Click += new System.EventHandler(this.LogIn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(7, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password:";
            // 
            // LogInPassword
            // 
            this.LogInPassword.Location = new System.Drawing.Point(131, 104);
            this.LogInPassword.Name = "LogInPassword";
            this.LogInPassword.Size = new System.Drawing.Size(191, 20);
            this.LogInPassword.TabIndex = 5;
            this.LogInPassword.UseSystemPasswordChar = true;
            // 
            // SignUp
            // 
            this.SignUp.BackColor = System.Drawing.Color.Transparent;
            this.SignUp.FlatAppearance.BorderSize = 0;
            this.SignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SignUp.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUp.ForeColor = System.Drawing.Color.White;
            this.SignUp.Image = ((System.Drawing.Image)(resources.GetObject("SignUp.Image")));
            this.SignUp.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SignUp.Location = new System.Drawing.Point(12, 317);
            this.SignUp.Name = "SignUp";
            this.SignUp.Size = new System.Drawing.Size(148, 41);
            this.SignUp.TabIndex = 9;
            this.SignUp.Text = "Sign Up";
            this.SignUp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SignUp.UseVisualStyleBackColor = false;
            this.SignUp.Click += new System.EventHandler(this.SignUp_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(7, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 32);
            this.label1.TabIndex = 11;
            this.label1.Text = "National ID:";
            // 
            // LogInNationlID
            // 
            this.LogInNationlID.Location = new System.Drawing.Point(155, 66);
            this.LogInNationlID.Name = "LogInNationlID";
            this.LogInNationlID.Size = new System.Drawing.Size(167, 20);
            this.LogInNationlID.TabIndex = 12;
            // 
            // ShowPassword
            // 
            this.ShowPassword.AutoSize = true;
            this.ShowPassword.BackColor = System.Drawing.Color.Transparent;
            this.ShowPassword.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowPassword.ForeColor = System.Drawing.Color.White;
            this.ShowPassword.Location = new System.Drawing.Point(328, 95);
            this.ShowPassword.Name = "ShowPassword";
            this.ShowPassword.Size = new System.Drawing.Size(95, 36);
            this.ShowPassword.TabIndex = 13;
            this.ShowPassword.Text = "Show";
            this.ShowPassword.UseVisualStyleBackColor = false;
            this.ShowPassword.CheckedChanged += new System.EventHandler(this.ShowPassword_CheckedChanged);
            // 
            // IsAdmin
            // 
            this.IsAdmin.AutoSize = true;
            this.IsAdmin.BackColor = System.Drawing.Color.Transparent;
            this.IsAdmin.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsAdmin.ForeColor = System.Drawing.Color.Transparent;
            this.IsAdmin.Location = new System.Drawing.Point(13, 139);
            this.IsAdmin.Name = "IsAdmin";
            this.IsAdmin.Size = new System.Drawing.Size(110, 36);
            this.IsAdmin.TabIndex = 14;
            this.IsAdmin.Text = "Admin";
            this.IsAdmin.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(332, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(246, 45);
            this.label3.TabIndex = 15;
            this.label3.Text = "Vaccine System";
            // 
            // LogInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.IsAdmin);
            this.Controls.Add(this.ShowPassword);
            this.Controls.Add(this.LogInNationlID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SignUp);
            this.Controls.Add(this.LogIn);
            this.Controls.Add(this.LogInPassword);
            this.Controls.Add(this.label2);
            this.Name = "LogInForm";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LogIn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox LogInPassword;
        private System.Windows.Forms.Button SignUp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox LogInNationlID;
        private System.Windows.Forms.CheckBox ShowPassword;
        private System.Windows.Forms.CheckBox IsAdmin;
        private System.Windows.Forms.Label label3;
    }
}



namespace VaccineTrackingSystem.Forms
{
    partial class UserUpdateForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserUpdateForm));
            this.label9 = new System.Windows.Forms.Label();
            this.UpdatedUserName = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.UpdatedUserPassword = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Female = new System.Windows.Forms.RadioButton();
            this.Male = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.UpdatedUserAge = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.UpdatedUserCountry = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.UpdatedUserGovernorate = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Two = new System.Windows.Forms.RadioButton();
            this.Zero = new System.Windows.Forms.RadioButton();
            this.One = new System.Windows.Forms.RadioButton();
            this.UserUpdating = new System.Windows.Forms.Button();
            this.BackBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(1, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 32);
            this.label9.TabIndex = 19;
            this.label9.Text = "Name:";
            // 
            // UpdatedUserName
            // 
            this.UpdatedUserName.Location = new System.Drawing.Point(96, 40);
            this.UpdatedUserName.Name = "UpdatedUserName";
            this.UpdatedUserName.Size = new System.Drawing.Size(232, 20);
            this.UpdatedUserName.TabIndex = 20;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Transparent;
            this.label12.Location = new System.Drawing.Point(1, 86);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(130, 32);
            this.label12.TabIndex = 22;
            this.label12.Text = "Password:";
            // 
            // UpdatedUserPassword
            // 
            this.UpdatedUserPassword.Location = new System.Drawing.Point(127, 90);
            this.UpdatedUserPassword.Name = "UpdatedUserPassword";
            this.UpdatedUserPassword.Size = new System.Drawing.Size(201, 20);
            this.UpdatedUserPassword.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(1, 140);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 32);
            this.label10.TabIndex = 24;
            this.label10.Text = "Age:";
            // 
            // Female
            // 
            this.Female.AutoSize = true;
            this.Female.BackColor = System.Drawing.Color.Transparent;
            this.Female.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Female.ForeColor = System.Drawing.Color.White;
            this.Female.Location = new System.Drawing.Point(6, 34);
            this.Female.Name = "Female";
            this.Female.Size = new System.Drawing.Size(113, 36);
            this.Female.TabIndex = 29;
            this.Female.TabStop = true;
            this.Female.Text = "Female";
            this.Female.UseVisualStyleBackColor = false;
            // 
            // Male
            // 
            this.Male.AutoSize = true;
            this.Male.BackColor = System.Drawing.Color.Transparent;
            this.Male.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Male.ForeColor = System.Drawing.Color.White;
            this.Male.Location = new System.Drawing.Point(141, 34);
            this.Male.Name = "Male";
            this.Male.Size = new System.Drawing.Size(89, 36);
            this.Male.TabIndex = 30;
            this.Male.TabStop = true;
            this.Male.Text = "Male";
            this.Male.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.Female);
            this.groupBox1.Controls.Add(this.Male);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(7, 324);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(261, 79);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gender";
            // 
            // UpdatedUserAge
            // 
            this.UpdatedUserAge.Location = new System.Drawing.Point(65, 152);
            this.UpdatedUserAge.Name = "UpdatedUserAge";
            this.UpdatedUserAge.Size = new System.Drawing.Size(263, 20);
            this.UpdatedUserAge.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(1, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 32);
            this.label1.TabIndex = 33;
            this.label1.Text = "Country:";
            // 
            // UpdatedUserCountry
            // 
            this.UpdatedUserCountry.Location = new System.Drawing.Point(118, 209);
            this.UpdatedUserCountry.Name = "UpdatedUserCountry";
            this.UpdatedUserCountry.Size = new System.Drawing.Size(210, 20);
            this.UpdatedUserCountry.TabIndex = 34;
            this.UpdatedUserCountry.TextChanged += new System.EventHandler(this.UpdatedUserCountry_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(1, 251);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 32);
            this.label2.TabIndex = 35;
            this.label2.Text = "Governorate:";
            // 
            // UpdatedUserGovernorate
            // 
            this.UpdatedUserGovernorate.FormattingEnabled = true;
            this.UpdatedUserGovernorate.Location = new System.Drawing.Point(161, 262);
            this.UpdatedUserGovernorate.Name = "UpdatedUserGovernorate";
            this.UpdatedUserGovernorate.Size = new System.Drawing.Size(167, 21);
            this.UpdatedUserGovernorate.TabIndex = 36;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.Two);
            this.groupBox2.Controls.Add(this.Zero);
            this.groupBox2.Controls.Add(this.One);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(286, 324);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(261, 79);
            this.groupBox2.TabIndex = 37;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Vaccinated";
            // 
            // Two
            // 
            this.Two.AutoSize = true;
            this.Two.BackColor = System.Drawing.Color.Transparent;
            this.Two.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Two.ForeColor = System.Drawing.Color.White;
            this.Two.Location = new System.Drawing.Point(148, 34);
            this.Two.Name = "Two";
            this.Two.Size = new System.Drawing.Size(47, 36);
            this.Two.TabIndex = 32;
            this.Two.TabStop = true;
            this.Two.Text = "2";
            this.Two.UseVisualStyleBackColor = false;
            // 
            // Zero
            // 
            this.Zero.AutoSize = true;
            this.Zero.BackColor = System.Drawing.Color.Transparent;
            this.Zero.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Zero.ForeColor = System.Drawing.Color.White;
            this.Zero.Location = new System.Drawing.Point(6, 34);
            this.Zero.Name = "Zero";
            this.Zero.Size = new System.Drawing.Size(47, 36);
            this.Zero.TabIndex = 29;
            this.Zero.TabStop = true;
            this.Zero.Text = "0";
            this.Zero.UseVisualStyleBackColor = false;
            // 
            // One
            // 
            this.One.AutoSize = true;
            this.One.BackColor = System.Drawing.Color.Transparent;
            this.One.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.One.ForeColor = System.Drawing.Color.White;
            this.One.Location = new System.Drawing.Point(83, 34);
            this.One.Name = "One";
            this.One.Size = new System.Drawing.Size(47, 36);
            this.One.TabIndex = 30;
            this.One.TabStop = true;
            this.One.Text = "1";
            this.One.UseVisualStyleBackColor = false;
            // 
            // UserUpdating
            // 
            this.UserUpdating.BackColor = System.Drawing.Color.Transparent;
            this.UserUpdating.FlatAppearance.BorderSize = 0;
            this.UserUpdating.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UserUpdating.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserUpdating.ForeColor = System.Drawing.Color.White;
            this.UserUpdating.Image = ((System.Drawing.Image)(resources.GetObject("UserUpdating.Image")));
            this.UserUpdating.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.UserUpdating.Location = new System.Drawing.Point(292, 423);
            this.UserUpdating.Name = "UserUpdating";
            this.UserUpdating.Size = new System.Drawing.Size(128, 36);
            this.UserUpdating.TabIndex = 38;
            this.UserUpdating.Text = "Update";
            this.UserUpdating.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.UserUpdating.UseVisualStyleBackColor = false;
            this.UserUpdating.Click += new System.EventHandler(this.UserUpdating_Click);
            // 
            // BackBtn
            // 
            this.BackBtn.BackColor = System.Drawing.Color.Transparent;
            this.BackBtn.FlatAppearance.BorderSize = 0;
            this.BackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackBtn.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold);
            this.BackBtn.ForeColor = System.Drawing.Color.White;
            this.BackBtn.Image = ((System.Drawing.Image)(resources.GetObject("BackBtn.Image")));
            this.BackBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BackBtn.Location = new System.Drawing.Point(586, 0);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(118, 48);
            this.BackBtn.TabIndex = 40;
            this.BackBtn.Text = "Back";
            this.BackBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BackBtn.UseVisualStyleBackColor = false;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // UserUpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(703, 471);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.UserUpdating);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.UpdatedUserGovernorate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.UpdatedUserCountry);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UpdatedUserAge);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.UpdatedUserPassword);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.UpdatedUserName);
            this.Controls.Add(this.label9);
            this.Name = "UserUpdateForm";
            this.Text = "UserUpdateForm";
            this.Load += new System.EventHandler(this.UserUpdateForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox UpdatedUserName;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox UpdatedUserPassword;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RadioButton Female;
        private System.Windows.Forms.RadioButton Male;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox UpdatedUserAge;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox UpdatedUserCountry;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox UpdatedUserGovernorate;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton Zero;
        private System.Windows.Forms.RadioButton One;
        private System.Windows.Forms.RadioButton Two;
        private System.Windows.Forms.Button UserUpdating;
        private System.Windows.Forms.Button BackBtn;
    }
}
namespace VaccineTrackingSystem
{
    partial class UserAddingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserAddingForm));
            this.UserName = new System.Windows.Forms.TextBox();
            this.UserPassword = new System.Windows.Forms.TextBox();
            this.UserCountry = new System.Windows.Forms.TextBox();
            this.UserAge = new System.Windows.Forms.TextBox();
            this.UserGovernorate = new System.Windows.Forms.ComboBox();
            this.UserAdding = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.UserNationalID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Female = new System.Windows.Forms.RadioButton();
            this.Male = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Two = new System.Windows.Forms.RadioButton();
            this.Zero = new System.Windows.Forms.RadioButton();
            this.One = new System.Windows.Forms.RadioButton();
            this.BackBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // UserName
            // 
            this.UserName.Location = new System.Drawing.Point(81, 40);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(157, 20);
            this.UserName.TabIndex = 1;
            // 
            // UserPassword
            // 
            this.UserPassword.Location = new System.Drawing.Point(117, 95);
            this.UserPassword.Name = "UserPassword";
            this.UserPassword.Size = new System.Drawing.Size(121, 20);
            this.UserPassword.TabIndex = 2;
            // 
            // UserCountry
            // 
            this.UserCountry.Location = new System.Drawing.Point(357, 95);
            this.UserCountry.Name = "UserCountry";
            this.UserCountry.Size = new System.Drawing.Size(182, 20);
            this.UserCountry.TabIndex = 4;
            // 
            // UserAge
            // 
            this.UserAge.Location = new System.Drawing.Point(71, 144);
            this.UserAge.Name = "UserAge";
            this.UserAge.Size = new System.Drawing.Size(167, 20);
            this.UserAge.TabIndex = 5;
            // 
            // UserGovernorate
            // 
            this.UserGovernorate.FormattingEnabled = true;
            this.UserGovernorate.Location = new System.Drawing.Point(395, 144);
            this.UserGovernorate.Name = "UserGovernorate";
            this.UserGovernorate.Size = new System.Drawing.Size(144, 21);
            this.UserGovernorate.TabIndex = 13;
            // 
            // UserAdding
            // 
            this.UserAdding.BackColor = System.Drawing.Color.Transparent;
            this.UserAdding.FlatAppearance.BorderSize = 0;
            this.UserAdding.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UserAdding.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserAdding.ForeColor = System.Drawing.Color.White;
            this.UserAdding.Image = ((System.Drawing.Image)(resources.GetObject("UserAdding.Image")));
            this.UserAdding.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.UserAdding.Location = new System.Drawing.Point(298, 423);
            this.UserAdding.Name = "UserAdding";
            this.UserAdding.Size = new System.Drawing.Size(91, 36);
            this.UserAdding.TabIndex = 17;
            this.UserAdding.Text = "Add";
            this.UserAdding.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.UserAdding.UseVisualStyleBackColor = false;
            this.UserAdding.Click += new System.EventHandler(this.UserAdding_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Comic Sans MS", 15.75F);
            this.label9.ForeColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(1, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 29);
            this.label9.TabIndex = 18;
            this.label9.Text = "Name:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Comic Sans MS", 15.75F);
            this.label10.ForeColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(1, 135);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 29);
            this.label10.TabIndex = 19;
            this.label10.Text = "Age:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Comic Sans MS", 15.75F);
            this.label12.ForeColor = System.Drawing.Color.Transparent;
            this.label12.Location = new System.Drawing.Point(1, 86);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(109, 29);
            this.label12.TabIndex = 21;
            this.label12.Text = "Password:";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.BackColor = System.Drawing.Color.Transparent;
            this.label.Font = new System.Drawing.Font("Comic Sans MS", 15.75F);
            this.label.ForeColor = System.Drawing.Color.Transparent;
            this.label.Location = new System.Drawing.Point(255, 31);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(134, 29);
            this.label.TabIndex = 22;
            this.label.Text = "National ID:";
            // 
            // UserNationalID
            // 
            this.UserNationalID.Location = new System.Drawing.Point(395, 40);
            this.UserNationalID.Name = "UserNationalID";
            this.UserNationalID.Size = new System.Drawing.Size(144, 20);
            this.UserNationalID.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 15.75F);
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(255, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 29);
            this.label1.TabIndex = 24;
            this.label1.Text = "Country:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 15.75F);
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(255, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 29);
            this.label2.TabIndex = 25;
            this.label2.Text = "Governorate:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.Female);
            this.groupBox1.Controls.Add(this.Male);
            this.groupBox1.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(6, 191);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(261, 73);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gender";
            // 
            // Female
            // 
            this.Female.AutoSize = true;
            this.Female.BackColor = System.Drawing.Color.Transparent;
            this.Female.Font = new System.Drawing.Font("Comic Sans MS", 15.75F);
            this.Female.ForeColor = System.Drawing.Color.White;
            this.Female.Location = new System.Drawing.Point(6, 34);
            this.Female.Name = "Female";
            this.Female.Size = new System.Drawing.Size(99, 33);
            this.Female.TabIndex = 29;
            this.Female.TabStop = true;
            this.Female.Text = "Female";
            this.Female.UseVisualStyleBackColor = false;
            // 
            // Male
            // 
            this.Male.AutoSize = true;
            this.Male.BackColor = System.Drawing.Color.Transparent;
            this.Male.Font = new System.Drawing.Font("Comic Sans MS", 15.75F);
            this.Male.ForeColor = System.Drawing.Color.White;
            this.Male.Location = new System.Drawing.Point(139, 34);
            this.Male.Name = "Male";
            this.Male.Size = new System.Drawing.Size(78, 33);
            this.Male.TabIndex = 30;
            this.Male.TabStop = true;
            this.Male.Text = "Male";
            this.Male.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.Two);
            this.groupBox2.Controls.Add(this.Zero);
            this.groupBox2.Controls.Add(this.One);
            this.groupBox2.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(6, 293);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(261, 79);
            this.groupBox2.TabIndex = 38;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Vaccinated";
            // 
            // Two
            // 
            this.Two.AutoSize = true;
            this.Two.BackColor = System.Drawing.Color.Transparent;
            this.Two.Font = new System.Drawing.Font("Comic Sans MS", 15.75F);
            this.Two.ForeColor = System.Drawing.Color.White;
            this.Two.Location = new System.Drawing.Point(148, 34);
            this.Two.Name = "Two";
            this.Two.Size = new System.Drawing.Size(44, 33);
            this.Two.TabIndex = 32;
            this.Two.TabStop = true;
            this.Two.Text = "2";
            this.Two.UseVisualStyleBackColor = false;
            // 
            // Zero
            // 
            this.Zero.AutoSize = true;
            this.Zero.BackColor = System.Drawing.Color.Transparent;
            this.Zero.Font = new System.Drawing.Font("Comic Sans MS", 15.75F);
            this.Zero.ForeColor = System.Drawing.Color.White;
            this.Zero.Location = new System.Drawing.Point(6, 34);
            this.Zero.Name = "Zero";
            this.Zero.Size = new System.Drawing.Size(44, 33);
            this.Zero.TabIndex = 29;
            this.Zero.TabStop = true;
            this.Zero.Text = "0";
            this.Zero.UseVisualStyleBackColor = false;
            // 
            // One
            // 
            this.One.AutoSize = true;
            this.One.BackColor = System.Drawing.Color.Transparent;
            this.One.Font = new System.Drawing.Font("Comic Sans MS", 15.75F);
            this.One.ForeColor = System.Drawing.Color.White;
            this.One.Location = new System.Drawing.Point(83, 34);
            this.One.Name = "One";
            this.One.Size = new System.Drawing.Size(40, 33);
            this.One.TabIndex = 30;
            this.One.TabStop = true;
            this.One.Text = "1";
            this.One.UseVisualStyleBackColor = false;
            // 
            // BackBtn
            // 
            this.BackBtn.BackColor = System.Drawing.Color.Transparent;
            this.BackBtn.FlatAppearance.BorderSize = 0;
            this.BackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackBtn.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackBtn.ForeColor = System.Drawing.Color.White;
            this.BackBtn.Image = ((System.Drawing.Image)(resources.GetObject("BackBtn.Image")));
            this.BackBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BackBtn.Location = new System.Drawing.Point(582, 12);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(109, 36);
            this.BackBtn.TabIndex = 39;
            this.BackBtn.Text = "Back";
            this.BackBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BackBtn.UseVisualStyleBackColor = false;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // UserAddingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(703, 471);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UserNationalID);
            this.Controls.Add(this.label);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.UserAdding);
            this.Controls.Add(this.UserGovernorate);
            this.Controls.Add(this.UserAge);
            this.Controls.Add(this.UserCountry);
            this.Controls.Add(this.UserPassword);
            this.Controls.Add(this.UserName);
            this.DoubleBuffered = true;
            this.Name = "UserAddingForm";
            this.Text = "Sign up";
            this.Load += new System.EventHandler(this.UserForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox UserName;
        private System.Windows.Forms.TextBox UserPassword;
        private System.Windows.Forms.TextBox UserCountry;
        private System.Windows.Forms.TextBox UserAge;
        private System.Windows.Forms.ComboBox UserGovernorate;
        private System.Windows.Forms.Button UserAdding;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox UserNationalID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton Female;
        private System.Windows.Forms.RadioButton Male;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton Two;
        private System.Windows.Forms.RadioButton Zero;
        private System.Windows.Forms.RadioButton One;
        private System.Windows.Forms.Button BackBtn;
    }
}
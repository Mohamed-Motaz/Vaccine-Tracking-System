namespace VaccineTrackingSystem.Forms
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.Statistics = new System.Windows.Forms.Button();
            this.WaitingList = new System.Windows.Forms.Button();
            this.UserControl = new System.Windows.Forms.Button();
            this.BackBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Statistics
            // 
            this.Statistics.BackColor = System.Drawing.Color.Transparent;
            this.Statistics.FlatAppearance.BorderSize = 0;
            this.Statistics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Statistics.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Statistics.ForeColor = System.Drawing.Color.White;
            this.Statistics.Image = ((System.Drawing.Image)(resources.GetObject("Statistics.Image")));
            this.Statistics.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Statistics.Location = new System.Drawing.Point(-1, 3);
            this.Statistics.Name = "Statistics";
            this.Statistics.Size = new System.Drawing.Size(157, 68);
            this.Statistics.TabIndex = 18;
            this.Statistics.Text = "Statistics";
            this.Statistics.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Statistics.UseVisualStyleBackColor = false;
            this.Statistics.Click += new System.EventHandler(this.Statistics_Click);
            // 
            // WaitingList
            // 
            this.WaitingList.BackColor = System.Drawing.Color.Transparent;
            this.WaitingList.FlatAppearance.BorderSize = 0;
            this.WaitingList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WaitingList.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WaitingList.ForeColor = System.Drawing.Color.White;
            this.WaitingList.Image = ((System.Drawing.Image)(resources.GetObject("WaitingList.Image")));
            this.WaitingList.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.WaitingList.Location = new System.Drawing.Point(352, 7);
            this.WaitingList.Name = "WaitingList";
            this.WaitingList.Size = new System.Drawing.Size(180, 68);
            this.WaitingList.TabIndex = 19;
            this.WaitingList.Text = "Waiting List";
            this.WaitingList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.WaitingList.UseVisualStyleBackColor = false;
            this.WaitingList.Click += new System.EventHandler(this.WaitingList_Click);
            // 
            // UserControl
            // 
            this.UserControl.BackColor = System.Drawing.Color.Transparent;
            this.UserControl.FlatAppearance.BorderSize = 0;
            this.UserControl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UserControl.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserControl.ForeColor = System.Drawing.Color.White;
            this.UserControl.Image = ((System.Drawing.Image)(resources.GetObject("UserControl.Image")));
            this.UserControl.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.UserControl.Location = new System.Drawing.Point(162, -2);
            this.UserControl.Name = "UserControl";
            this.UserControl.Size = new System.Drawing.Size(184, 77);
            this.UserControl.TabIndex = 20;
            this.UserControl.Text = "User Control";
            this.UserControl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.UserControl.UseVisualStyleBackColor = false;
            this.UserControl.Click += new System.EventHandler(this.UserControl_Click);
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
            this.BackBtn.Location = new System.Drawing.Point(652, 7);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(109, 36);
            this.BackBtn.TabIndex = 40;
            this.BackBtn.Text = "Back";
            this.BackBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BackBtn.UseVisualStyleBackColor = false;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(773, 492);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.UserControl);
            this.Controls.Add(this.WaitingList);
            this.Controls.Add(this.Statistics);
            this.DoubleBuffered = true;
            this.Name = "AdminForm";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Statistics;
        private System.Windows.Forms.Button WaitingList;
        private System.Windows.Forms.Button UserControl;
        private System.Windows.Forms.Button BackBtn;
    }
}

namespace VaccineTrackingSystem.Forms
{
    partial class UserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserForm));
            this.UserUpdate = new System.Windows.Forms.Button();
            this.UserDelete = new System.Windows.Forms.Button();
            this.BackBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UserUpdate
            // 
            this.UserUpdate.BackColor = System.Drawing.Color.Transparent;
            this.UserUpdate.FlatAppearance.BorderSize = 0;
            this.UserUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UserUpdate.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserUpdate.ForeColor = System.Drawing.Color.White;
            this.UserUpdate.Image = ((System.Drawing.Image)(resources.GetObject("UserUpdate.Image")));
            this.UserUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.UserUpdate.Location = new System.Drawing.Point(12, 118);
            this.UserUpdate.Name = "UserUpdate";
            this.UserUpdate.Size = new System.Drawing.Size(151, 62);
            this.UserUpdate.TabIndex = 10;
            this.UserUpdate.Text = "Update";
            this.UserUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.UserUpdate.UseVisualStyleBackColor = false;
            // 
            // UserDelete
            // 
            this.UserDelete.BackColor = System.Drawing.Color.Transparent;
            this.UserDelete.FlatAppearance.BorderSize = 0;
            this.UserDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UserDelete.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserDelete.ForeColor = System.Drawing.Color.White;
            this.UserDelete.Image = ((System.Drawing.Image)(resources.GetObject("UserDelete.Image")));
            this.UserDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.UserDelete.Location = new System.Drawing.Point(12, 219);
            this.UserDelete.Name = "UserDelete";
            this.UserDelete.Size = new System.Drawing.Size(151, 62);
            this.UserDelete.TabIndex = 11;
            this.UserDelete.Text = "Delete";
            this.UserDelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.UserDelete.UseVisualStyleBackColor = false;
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
            this.BackBtn.Location = new System.Drawing.Point(615, 12);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(109, 36);
            this.BackBtn.TabIndex = 40;
            this.BackBtn.Text = "Back";
            this.BackBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BackBtn.UseVisualStyleBackColor = false;
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(736, 451);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.UserDelete);
            this.Controls.Add(this.UserUpdate);
            this.Name = "UserForm";
            this.Text = "UserForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button UserUpdate;
        private System.Windows.Forms.Button UserDelete;
        private System.Windows.Forms.Button BackBtn;
    }
}
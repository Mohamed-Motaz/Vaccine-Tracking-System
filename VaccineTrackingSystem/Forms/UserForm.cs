using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VaccineTrackingSystem.DataModels;

namespace VaccineTrackingSystem.Forms
{
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
        }

        private void UserUpdate_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserUpdateForm form = new UserUpdateForm();
            form.ShowDialog();
            this.Close();
        }

        private void UserDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this user ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                User.HandleUserDelete(DataContainer.CurrentUser);
                MessageBox.Show("User successfully deleted");
                this.Hide();
                LogInForm form = new LogInForm();
                form.ShowDialog();
                this.Close();
                DataContainer.CurrentUser = null; //make sure current user is no longer logged in
            }
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            DataContainer.CurrentUser = null; //make sure current user is no longer logged in
            this.Hide();
            LogInForm form = new LogInForm();
            form.ShowDialog();
            this.Close();
        }
    }
}

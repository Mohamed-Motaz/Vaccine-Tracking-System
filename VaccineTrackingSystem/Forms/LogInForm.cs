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
using VaccineTrackingSystem.Forms;

namespace VaccineTrackingSystem
{
    public partial class LogInForm : Form
    {
        public LogInForm()
        {
            InitializeComponent();
        }

        private void LogIn_Click(object sender, EventArgs e)
        {
            if (IsAdmin.Checked)
                if (LogInPassword.Text == DataContainer.AdminPassword)
                {
                    this.Hide();                    
                    AdminForm form = new AdminForm();
                    form.ShowDialog();
                    this.Close();
                }
                else
                    MessageBox.Show("Password is incorrect!");
            else
            {
                bool found = false;
                User tempUser = new User();

                if (DataContainer.UsersMap.ContainsKey(LogInNationlID.Text))
                {
                    tempUser = DataContainer.UsersMap[LogInNationlID.Text];
                    found = true;
                }

                if (found)
                    if (LogInPassword.Text == tempUser.Password)
                    {
                        DataContainer.CurrentUser = tempUser;
                        this.Hide();
                        UserForm form = new UserForm();
                        form.ShowDialog();
                        this.Close();
                    }
                    else
                        MessageBox.Show("Password is incorrect!");
                else
                    MessageBox.Show("National ID is incorrect!");
            }
        }

        private void SignUp_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserAddingForm form = new UserAddingForm();
            form.ShowDialog();
            this.Close();
        }

        private void ShowPassword_CheckedChanged(object sender, EventArgs e)
        {

            if (ShowPassword.Checked)
            {
                LogInPassword.UseSystemPasswordChar = false;
            }
            else
                LogInPassword.UseSystemPasswordChar = true;
        }
    }
}
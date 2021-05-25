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
            {
                if (LogInPassword.Text == DataContainer.adminPassword)
                {
                    AdminForm form = new AdminForm();
                    form.Show();
                }
                else
                    MessageBox.Show("Password is wrong!");


            }
            else
            {
                Boolean found = false;

                User temp = new User();


                if (DataContainer.usersMap.ContainsKey(LogInNationlID.Text))
                {
                    temp = DataContainer.usersMap[LogInNationlID.Text];
                    found = true;
                }

                if (found)
                {
                    if (LogInPassword.Text == temp.Password)
                    {
                        DataContainer.currentUser = temp;
                        UserForm form = new UserForm();
                        form.Show();
                    }
                    else
                        MessageBox.Show("Password is wrong!");

                }
                else
                    MessageBox.Show("National ID is wrong!");


            }


        }

        private void SignUp_Click(object sender, EventArgs e)
        {
            UserAddingForm form = new UserAddingForm();
            form.Show();
        }
    }
}
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
            UserForm form = new UserForm();
            form.ShowDialog();
            this.Close();
        }

        private void UserDelete_Click(object sender, EventArgs e)
        {
            User.HandleUserDelete(DataContainer.CurrentUser);
            this.Hide();
            LogInForm form = new LogInForm();
            form.ShowDialog();
            this.Close();
            
        }
    }
}

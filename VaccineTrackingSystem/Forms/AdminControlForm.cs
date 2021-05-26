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
    public partial class AdminControlForm : Form
    {
        public AdminControlForm()
        {
            InitializeComponent();
        }
        private void AdminControlForm_Load(object sender, EventArgs e)
        {

            userBindingSource.DataSource = DataContainer.Users;
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView.Columns[e.ColumnIndex].Name == "Delete")
            {
                if (MessageBox.Show("Are you sure you want to delete this customer ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    MessageBox.Show(((User)userBindingSource.Current).Country);
                    User tmpUser = (User)userBindingSource.Current;
                    userBindingSource.RemoveCurrent();
                    User.HandleUserDelete(tmpUser);
                }
            }
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {

            if (searchTextBox.Text.Length == 0)
            {
                userBindingSource.DataSource = DataContainer.Users;

            }
            else
            {
                List<User> newUsers = new List<User>();
                foreach(User usr in DataContainer.Users)
                {
                    if (usr.NationalID.Contains(searchTextBox.Text))
                    {

                        newUsers.Add(usr);
                    }
                }

                userBindingSource.DataSource = newUsers;
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void DeleteAllRecords_Click(object sender, EventArgs e)
        {
            DataContainer.Users.Clear();
            userBindingSource.DataSource = DataContainer.Users;
        }
    }
}

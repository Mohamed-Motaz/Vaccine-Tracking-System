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
          
            userBindingSource.DataSource = DataContainer.Users.ToList();
            
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView.Columns[e.ColumnIndex].Name == "Delete")
            {
                if (MessageBox.Show("Are you sure you want to delete this customer ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Console.WriteLine("in delete " + DataContainer.Users.CurrentPos);
                    User tmpUser = (User)userBindingSource.Current;
                    User.HandleUserDelete(tmpUser);                    
                    userBindingSource.RemoveCurrent();

                }
            }
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {

            if (searchTextBox.Text.Length == 0)
            {
                userBindingSource.DataSource = DataContainer.Users.ToList();

            }
            else
            {
                List<User> newUsers = new List<User>();

                foreach(User usr in DataContainer.Users)
                    if (usr.NationalID.Contains(searchTextBox.Text))
                        newUsers.Add(usr);

                userBindingSource.DataSource = newUsers;
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void DeleteAllRecords_Click(object sender, EventArgs e)
        {            
            userBindingSource.DataSource = new List<User>();
            Console.WriteLine(DataContainer.Users.CurrentPos);
            for(int i = 0; i <= DataContainer.Users.CurrentPos; i++)
            {
                User user = DataContainer.Users[i];
                User.HandleUserDelete(user);
                i--; //becuase of the implementation of remove in custom list
            }
            MessageBox.Show("All users succesfully deleted");
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminForm form = new AdminForm();
            form.ShowDialog();
            this.Close();
        }
    }
}

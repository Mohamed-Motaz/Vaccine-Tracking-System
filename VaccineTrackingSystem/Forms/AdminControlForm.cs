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
        List<User> tmp = new List<User>() { new User()
            {
                UserName = "Mohamed Motaz",
                NationalID = "hscdjkcd",
                Password = "dcnlkc",
                Gender = "Male",
                Age = 15,
                Governorate = "Giza",
                Vaccinated = 1
        },
        new User()
        {
            UserName = "Ali Agina",
                NationalID = "hscdjkcd",
                Password = "dcnlkc",
                Gender = "Male",
                Age = 15,
                Governorate = "Giza",
                Vaccinated = 1
            },
          new User()
        {
            UserName = "Kareem Ezzat",
                NationalID = "hscdjkcd",
                Password = "dcnlkc",
                Gender = "Male",
                Age = 15,
                Governorate = "Giza",
                Vaccinated = 1
            },
            new User()
        {
            UserName = "AbdelAzim",
                NationalID = "hscdjkcd",
                Password = "dcnlkc",
                Gender = "Male",
                Age = 15,
                Governorate = "Giza",
                Vaccinated = 1
            }, new User()
        {
            UserName = "Rawan Ahmed",
                NationalID = "hscdjkcd",
                Password = "dcnlkc",
                Gender = "Male",
                Age = 15,
                Governorate = "Giza",
                Vaccinated = 1
            }, new User()
        {
            UserName = "Salma Tarek",
                NationalID = "hscdjkcd",
                Password = "dcnlkc",
                Gender = "Male",
                Age = 15,
                Governorate = "Giza",
                Vaccinated = 1
            },
            };
        public AdminControlForm()
        {
            InitializeComponent();
        }

        private void AdminControlForm_Load(object sender, EventArgs e)
        {

            userBindingSource.DataSource = tmp;
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView.Columns[e.ColumnIndex].Name == "Delete")
            {
                if (MessageBox.Show("Are you sure you want to delete this customer ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    MessageBox.Show(((User)userBindingSource.Current).Country);
                    userBindingSource.RemoveCurrent();
                }
            }
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {

            if (searchTextBox.Text.Length == 0)
            {
                userBindingSource.DataSource = tmp;

            }
            else
            {
                List<User> newUsers = new List<User>();
                foreach(User usr in tmp)
                {
                    if (usr.UserName.ToLower().Contains(searchTextBox.Text))
                    {

                        newUsers.Add(usr);
                    }
                }

                userBindingSource.DataSource = newUsers;
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            DataContainer.users.Clear();
            userBindingSource.DataSource = DataContainer.users;
        }
    }
}

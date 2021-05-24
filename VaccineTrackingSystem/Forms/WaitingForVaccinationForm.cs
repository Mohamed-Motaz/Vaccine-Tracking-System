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
    public partial class WaitingForVaccinationForm : Form
    {
        public WaitingForVaccinationForm()
        {
            InitializeComponent();
        }
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
        private void WaitingForVaccinationForm_Load(object sender, EventArgs e)
        {

            foreach(User newUser in tmp)
            {
                ListItem newList = new ListItem();
                newList.name = newUser.UserName;
                newList.id = newUser.NationalID ;
                newList.pass = newUser.Password;
                newList.Gender = newUser.Gender;
                newList.age = newUser.Age;
                newList.contry = newUser.Governorate;
               

                if (flowLayoutPanel1.Controls.Count < 0)
                    flowLayoutPanel1.Controls.Clear();
                else
                    flowLayoutPanel1.Controls.Add(newList);
            }
        }


        private void listItem1_Load_1(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

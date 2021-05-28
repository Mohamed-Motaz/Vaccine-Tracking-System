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
        
        private void WaitingForVaccinationForm_Load(object sender, EventArgs e)
        {
            //Console.WriteLine(DataContainer.CurrentlyWaiting.Count);

            foreach(User newUser in DataContainer.CurrentlyWaiting)
            {
                ListItem newList = new ListItem();
                newList.name = newUser.UserName;
                newList.id = newUser.NationalID ;
                newList.pass = newUser.Password;
                newList.Gender = newUser.Gender;
                newList.age = newUser.Age;
                newList.country = newUser.Governorate;
               

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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminForm form = new AdminForm();
            form.ShowDialog();
            this.Close();
        }
    }
}

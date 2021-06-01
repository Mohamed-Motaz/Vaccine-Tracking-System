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
    public partial class StatisticsForm : Form
    {
        public StatisticsForm()
        {
            InitializeComponent();
        }


        private void CalculateForVaccineSystem_Click(object sender, EventArgs e)
        {

            double dose0 = 0, dose1 = 0, dose2 = 0;

            for (int i = 0; i < DataContainer.Users.Count(); i++)
            {
                if (DataContainer.Users[i].Vaccinated == 0)
                    dose0++;
                else if (DataContainer.Users[i].Vaccinated == 1)
                    dose1++;
                else
                    dose2++;
            }
            if (DataContainer.Users.Count() == 0)
            {
                textBox1.Text = "0%";
                textBox3.Text = "0%";
                textBox4.Text = "0%";
                textBox5.Text = "0%";
            }

            else
            {
                dose0 = (dose0 / DataContainer.Users.Count()) * 100;
                dose1 = (dose1 / DataContainer.Users.Count()) * 100;
                dose2 = (dose2 / DataContainer.Users.Count()) * 100;
                dose0 = Math.Round(dose0, 2);
                dose1 = Math.Round(dose1, 2);
                dose2 = Math.Round(dose2, 2);
                textBox1.Text = (((double)DataContainer.CurrentlyWaiting.Count() / DataContainer.Users.Count()) * 100).ToString() + '%';
                textBox3.Text = dose0.ToString() + '%';
                textBox4.Text = dose1.ToString() + '%';
                textBox5.Text = dose2.ToString() + '%';
            }
        }

        private void CalculateForEgypt_Click(object sender, EventArgs e)
        {

            double egyptPopulation = 104258327;

            double dose0 = 0, dose1 = 0, dose2 = 0;

            for (int i = 0; i < DataContainer.Users.Count(); i++)
            {
                if (DataContainer.Users[i].Vaccinated == 0)
                    dose0++;
                else if (DataContainer.Users[i].Vaccinated == 1)
                    dose1++;
                else
                    dose2++;
            }
            dose0 = (dose0 / egyptPopulation) * 100;
            dose1 = (dose1 / egyptPopulation) * 100;
            dose2 = (dose2 / egyptPopulation) * 100;
            dose0 = Math.Round(dose0, 9);
            dose1 = Math.Round(dose1, 9);
            dose2 = Math.Round(dose2, 9);

            textBox2.Text = (((double)DataContainer.CurrentlyWaiting.Count() / egyptPopulation) * 100).ToString() + '%';
            textBox6.Text = dose0.ToString() + '%';
            textBox9.Text = dose1.ToString() + '%';
            textBox8.Text = dose2.ToString() + '%';
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
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VaccineTrackingSystem.Forms;

namespace VaccineTrackingSystem.Forms
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {

        }

        private void WaitingList_Click(object sender, EventArgs e)
        {
            this.Hide();
            WaitingForVaccinationForm form = new WaitingForVaccinationForm();
            form.ShowDialog();
            this.Close();
        }

        private void Statistics_Click(object sender, EventArgs e)
        {
            this.Hide();
            StatisticsForm form = new StatisticsForm();
            form.ShowDialog();
            this.Close();
        }

        private void UserControl_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminControlForm form = new AdminControlForm();
            form.ShowDialog();
            this.Close();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogInForm form = new LogInForm();
            form.ShowDialog();
            this.Close();
        }

        private void DataVisualizationBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            DataVisualizationForm form = new DataVisualizationForm();
            form.ShowDialog();
            this.Close();
        }
    }
}

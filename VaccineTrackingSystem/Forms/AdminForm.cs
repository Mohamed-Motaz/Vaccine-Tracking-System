﻿using System;
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
            WaitingForVaccinationForm form = new WaitingForVaccinationForm();
            form.Show();
        }

        private void Statistics_Click(object sender, EventArgs e)
        {
            StatisticsForm form = new StatisticsForm();
            form.Show();
        }

        private void UserControl_Click(object sender, EventArgs e)
        {
            AdminControlForm form = new AdminControlForm();
            form.Show();
        }
    }
}

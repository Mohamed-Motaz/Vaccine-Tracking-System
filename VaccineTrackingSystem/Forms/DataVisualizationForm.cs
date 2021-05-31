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
    public partial class DataVisualizationForm : Form
    {
        public DataVisualizationForm()
        {
            InitializeComponent();
            int CntZeroDoses = 0, CntOneDose = 0, CntTwoDoses = 0, CntMales=0, CntFemales=0;
            foreach (User user in DataContainer.Users)
            {
                if (user.Vaccinated == 0)
                    CntZeroDoses++;
                else if (user.Vaccinated == 1)
                    CntOneDose++;
                else
                    CntTwoDoses++;
                if (user.Vaccinated > 0)
                {
                    if (user.Gender == "Male")
                        CntMales++;
                    else
                        CntFemales++;
                }
            }
            double Zero = CntZeroDoses * 1.0 / DataContainer.Users.Count();
            double One = CntOneDose * 1.0 / DataContainer.Users.Count();
            double Two = CntTwoDoses * 1.0 / DataContainer.Users.Count();
            double Males = CntMales*1.0/ DataContainer.Users.Count();
            double Females = CntFemales * 1.0 / DataContainer.Users.Count();
            VaccinatedChart.Series["s1"].IsValueShownAsLabel = true;
            VaccinatedChart.Series["s1"].Points.AddXY("Zero doses", Zero);
            VaccinatedChart.Series["s1"].Points.AddXY("One dose", One);
            VaccinatedChart.Series["s1"].Points.AddXY("Two doses", Two);
            GenderChart.Series["s1"].IsValueShownAsLabel = true;
            GenderChart.Series["s1"].Points.AddXY("Males", Males);
            GenderChart.Series["s1"].Points.AddXY("Females", Females);
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

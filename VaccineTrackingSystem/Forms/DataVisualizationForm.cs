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
        void GenerateVaccinatedChart()
        {
            double CntMales = 0, CntFemales = 0, Cnt = 0;
            foreach (User user in DataContainer.Users)
            {
                if (user.Vaccinated > 0)
                {
                    if (user.Gender == "Male")
                        CntMales++;
                    else
                        CntFemales++;
                    Cnt++;
                }
            }
            double Males = CntMales / Cnt, Females = CntFemales / Cnt;
           // GenderChart.Series["s1"].IsValueShownAsLabel = true;
            GenderChart.Series["s1"].Points.AddXY("Males", Males);
            GenderChart.Series["s1"].Points.AddXY("Females", Females);
        }
        void GenerateGovernoratesChart()
        {
            Dictionary<string, int> CntGovernorates = new Dictionary<string, int>();
            foreach (User user in DataContainer.Users)
            {
                CntGovernorates[user.Governorate] = 0;
            }
            double EgyptianUsers = 0;
            foreach (User user in DataContainer.Users)
            {
                if (user.Country.ToLower() != "egypt" || user.Vaccinated == 0)
                    continue;
                CntGovernorates[user.Governorate]++;
                EgyptianUsers++;
            }
            GovernoratesChart.Series["s1"].IsValueShownAsLabel = true;
            foreach (KeyValuePair<string, int> entry in CntGovernorates)
            {
                if (entry.Value > 0)
                {
                    double cnt = entry.Value / EgyptianUsers;
                    GovernoratesChart.Series["s1"].Points.AddXY(entry.Key, cnt);
                }
            }

        }
        void GenerateGenderChart()
        {
            double CntZeroDoses = 0, CntOneDose = 0, CntTwoDoses = 0;
            foreach (User user in DataContainer.Users)
            {
                if (user.Vaccinated == 0)
                    CntZeroDoses++;
                else if (user.Vaccinated == 1)
                    CntOneDose++;
                else
                    CntTwoDoses++;
            }
            double Zero = CntZeroDoses / DataContainer.Users.Count(), One = CntOneDose / DataContainer.Users.Count(), Two = CntTwoDoses / DataContainer.Users.Count();
            VaccinatedChart.Series["s1"].IsValueShownAsLabel = true;
            VaccinatedChart.Series["s1"].Points.AddXY("Zero doses", Zero);
            VaccinatedChart.Series["s1"].Points.AddXY("One dose", One);
            VaccinatedChart.Series["s1"].Points.AddXY("Two doses", Two);
        }
        public DataVisualizationForm()
        {
            InitializeComponent();
            GenerateGenderChart();
            GenerateGovernoratesChart();
            GenerateVaccinatedChart();
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

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VaccineTrackingSystem.DataModels ;
namespace VaccineTrackingSystem
{
    public partial class UserForm : Form
    {
      
        public UserForm()
        {
            InitializeComponent();
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            UserGovernorate.Items.Insert(0, "Cairo");
            UserGovernorate.Items.Insert(1, "Alexandria");
            UserGovernorate.Items.Insert(2, "Aswan");
            UserGovernorate.Items.Insert(3, "Asyut");
            UserGovernorate.Items.Insert(4, "Beheira");
            UserGovernorate.Items.Insert(5, "Beni Suef");
            UserGovernorate.Items.Insert(6, "Dakahlia");
            UserGovernorate.Items.Insert(7, "Damietta");
            UserGovernorate.Items.Insert(8, "Faiyum");
            UserGovernorate.Items.Insert(9, "Gharbia");
            UserGovernorate.Items.Insert(10, "Giza");
            UserGovernorate.Items.Insert(11, "Ismailia");
            UserGovernorate.Items.Insert(12, "Kafr El Sheikh");
            UserGovernorate.Items.Insert(13, "Luxor");
            UserGovernorate.Items.Insert(14, "Matruh");
            UserGovernorate.Items.Insert(15, "Minya");
            UserGovernorate.Items.Insert(16, "Monufia");
            UserGovernorate.Items.Insert(17, "New Valley");
            UserGovernorate.Items.Insert(18, "North Sinai");
            UserGovernorate.Items.Insert(19, "Port Said");
            UserGovernorate.Items.Insert(20, "Qalyubia");
            UserGovernorate.Items.Insert(21, "Qena");
            UserGovernorate.Items.Insert(22, "Red Sea");
            UserGovernorate.Items.Insert(23, "Sharqia");
            UserGovernorate.Items.Insert(24, "Sohag");
            UserGovernorate.Items.Insert(25, "South Sinai");
            UserGovernorate.Items.Insert(26, "Suez");
          
        }
          public bool Validation() {
            if (UserNationalID.Text.Length!=13)

            {
                MessageBox.Show("Enter 13 number");

                return false;
            }
                if (DataContainer.usersMap.ContainsKey(UserNationalID.Text))
                {
                    MessageBox.Show("This NationalId Entered Before");
                    return false;
                }
            if (!IsAllDigits(UserNationalID.Text))
            {
                return false;
            }
            return true;
            }

        bool IsAllDigits(string s)
        {
            foreach (char c in s)
            {
                if (!char.IsDigit(c))
                    MessageBox.Show("Enter Numbers only");
                return false;
            }
            return true;
        }

        private void UserSubmit_Click(object sender, EventArgs e)
        {
            int age;

            User user = new User();
            user.UserName = UserName.Text;
           
            if (!Validate())
            {
                return;
            }
            user.NationalID = UserNationalID.Text;
            user.Governorate = UserGovernorate.Text;
            user.Password = UserPassword.Text;
            user.Country = UserCountry.Text;
           if(IsAllDigits (UserAge.Text)){

                age = Convert.ToInt32(UserAge.Text);
                if (age < 0 || age > 110)
                {
                    MessageBox.Show("Enter Age Between 1 and 110");
                    return;
                }
            }
            else
            {
                return;
            }
            user.Age =age;

            
            if (Female.Checked)
            {
                user.Gender = "Female";
            }
            else if (Male.Checked)
            {
                user.Gender = "Male";
            }

            if (Zero.Checked)
            {
                user.Vaccinated = 0;
            }
            else if (One.Checked)
            {
                user.Vaccinated = 1;
            }
            else if (Two.Checked)
            {
                user.Vaccinated = 2;
            }
            User.HandleUserUpdate(user);
        }

        private void UserGovernorate_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

}

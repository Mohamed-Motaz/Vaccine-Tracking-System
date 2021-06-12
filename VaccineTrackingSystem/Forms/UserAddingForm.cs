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

namespace VaccineTrackingSystem
{
    public partial class UserAddingForm : Form
    {
      
        public UserAddingForm()
        {
            InitializeComponent();
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            FillEgyptianGovernorates();
            UserGovernorate.Enabled = false;  //enable only when country set to egypt
        }

        private void UserAdding_Click(object sender, EventArgs e)
        {
            if (!Validate())
                return;

            User user = FillUserData();
            User.HandleUserAddition(user);
            MessageBox.Show("User Successfully Added");
            this.Hide();
            LogInForm form = new LogInForm();
            form.ShowDialog();
            this.Close();
        }
        private void FillEgyptianGovernorates()
        {
            foreach (string governorate in DataContainer.EgyptianGovernorates)
                UserGovernorate.Items.Add(governorate);
        }
        private User FillUserData()
        {
            User user = new User();
            user.UserName = UserName.Text;
            user.NationalID = UserNationalID.Text;
            user.Governorate = UserGovernorate.Text;
            user.Password = UserPassword.Text;
            user.Country = UserCountry.Text;
            user.Age = Convert.ToInt32(UserAge.Text);
            if (Female.Checked)
                user.Gender = "Female";
            else if (Male.Checked)
                user.Gender = "Male";
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
            return user;
        }
        public bool Validate()
        {
            if (UserNationalID.Text.Length != 13)
            {
                MessageBox.Show("Enter 13 numbers for the National ID");
                return false;
            }
            if (DataContainer.UsersMap.ContainsKey(UserNationalID.Text))
            {
                MessageBox.Show("National ID already exists");
                return false;
            }
            if (String.IsNullOrEmpty(UserCountry.Text) || String.IsNullOrEmpty(UserPassword.Text) || String.IsNullOrEmpty(UserName.Text))
            {
                MessageBox.Show("Fields cannot be left empty");
                return false;
            }
            try
            {
                Convert.ToInt64(UserNationalID.Text);
            }catch (Exception e) 
            { 
                MessageBox.Show("National ID should only be digits");
                return false;
            }
            int age;
            try
            {
                age = Convert.ToInt32(UserAge.Text);
            }
            catch (Exception e)
            {
                MessageBox.Show("Age should only be digits");
                return false;

            }
            if (age < 0 || age > 110)
            {
                MessageBox.Show("Enter Age Between 0 and 110");
                return false;
            }
            if (UserCountry.Text.ToLower() == "egypt" && !DataContainer.EgyptianGovernorates.Contains(UserGovernorate.Text))
            {
                MessageBox.Show("Governorate must be in Egypt");
                return false;
            }
            return true;
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            DataContainer.CurrentUser = null;
            this.Hide();
            LogInForm form = new LogInForm();
            form.ShowDialog();
            this.Close();
        }

        private void UserCountry_TextChanged(object sender, EventArgs e)
        {
            if (UserCountry.Text.ToLower() == "egypt")
                UserGovernorate.Enabled = true;
            else
            {
                UserGovernorate.Text = "";
                UserGovernorate.Enabled = false;
            }
        }

        private void UserGovernorate_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

}

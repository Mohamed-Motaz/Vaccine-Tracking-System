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
    public partial class UserUpdateForm : Form
    {
        public UserUpdateForm()
        {
            InitializeComponent();
        }

        private void UserUpdateForm_Load(object sender, EventArgs e)
        {
            FillEgyptianGovernorates();
            FillFormData();
        }  
        
        private void UserUpdating_Click(object sender, EventArgs e)
        {
            if (!Validate())
                return;
            FillUserData(ref DataContainer.CurrentUser);
            User.HandleUserUpdate(DataContainer.CurrentUser);
            MessageBox.Show("User Successfully Updated");
            this.Hide();
            LogInForm form = new LogInForm();
            form.ShowDialog();
            this.Close();
            DataContainer.CurrentUser = null;
        }        
        private void FillEgyptianGovernorates()
        {
            foreach (string governorate in DataContainer.EgyptianGovernorates)
                UpdatedUserGovernorate.Items.Add(governorate);
        }
        private void FillFormData()
        {
            UpdatedUserName.Text = DataContainer.CurrentUser.UserName;
            UpdatedUserGovernorate.Text = DataContainer.CurrentUser.Governorate;
            UpdatedUserPassword.Text = DataContainer.CurrentUser.Password;
            UpdatedUserCountry.Text = DataContainer.CurrentUser.Country;
            UpdatedUserAge.Text = DataContainer.CurrentUser.Age.ToString();

            if (DataContainer.CurrentUser.Gender == "Male")
                Male.Checked = true;
            else
                Female.Checked = true;

            if (DataContainer.CurrentUser.Vaccinated == 0)
                Zero.Checked = true;
            else if (DataContainer.CurrentUser.Vaccinated == 1)
                One.Checked = true;
            else
                Two.Checked = true;

        }
        private void FillUserData(ref User user)
        {
            user.UserName = UpdatedUserName.Text;
            user.Governorate = UpdatedUserGovernorate.Text;
            user.Password = UpdatedUserPassword.Text;
            user.Country = UpdatedUserCountry.Text;
            user.Age = Convert.ToInt32(UpdatedUserAge.Text);

            if (Zero.Checked)
                user.Vaccinated = 0;
            else if (One.Checked)
                user.Vaccinated = 1;
            else if (Two.Checked)
                user.Vaccinated = 2;
        }

        public bool Validate()
        {
            int age;
            try
            {
                age = Convert.ToInt32(UpdatedUserAge.Text);
            }
            catch (Exception e)
            {
                MessageBox.Show("Age should only be digits");
                return false;

            }
            if (age < 0 || age > 110)
            {
                MessageBox.Show("Enter Age Between 1 and 110");
                return false;
            }
            if (UpdatedUserCountry.Text.ToLower() == "egypt" && !DataContainer.EgyptianGovernorates.Contains(UpdatedUserGovernorate.Text))
            {
                MessageBox.Show("Governorate must be in Egypt");
                return false;
            }
            if (Female.Checked && DataContainer.CurrentUser.Gender == "Male")
            {
                MessageBox.Show("You can't change your gender from male to female!");
                return false;
            }
            if (Male.Checked && DataContainer.CurrentUser.Gender == "Female")
            {
                MessageBox.Show("You can't change your gender from female to male!");
                return false;
            }
            if ((Zero.Checked && DataContainer.CurrentUser.Vaccinated > 0) || (One.Checked && DataContainer.CurrentUser.Vaccinated > 1))
            {
                MessageBox.Show("You can't decrease your vaccine doses!");
                return false;
            }
            
            return true;
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserForm form = new UserForm();
            form.ShowDialog();
            this.Close();
        }

        private void UpdatedUserCountry_TextChanged(object sender, EventArgs e)
        {
            
                if (UpdatedUserCountry.Text.ToLower() == "egypt")
                    UpdatedUserGovernorate.Enabled = true;
                else
                {
                    UpdatedUserGovernorate.Text = "";
                    UpdatedUserGovernorate.Enabled = false;
                }
            
        }
    }
}

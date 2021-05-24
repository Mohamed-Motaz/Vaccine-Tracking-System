using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VaccineTrackingSystem.DataModels
{
    class User
    {

        public string UserName { get; set; } = "";
        public string NationalID { get; set; } = "";
        public string Password { get; set; } = "";
        public string Gender { get; set; } = "";   
        public int Age { get; set; } = 0;
        public string Country { get; set; } = "Egypt";
        public string Governorate { get; set; } = "";
        public int Vaccinated { get; set; } = 0; //stands for number of doses taken, 0, 1, or 2


        //general functions

        //handle updating user information
        //should handle removing and adding to waiting list

        public static void HandleUserUpdate(User user)
        {
        }
        public static void HandleUserDelete(User user)
        {

        }
    }
}

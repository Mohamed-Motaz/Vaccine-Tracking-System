using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VaccineTrackingSystem.DataModels
{
    class User
    {

        public string UserName = "";
        public string NationalID = "";
        public string Password = "";
        public bool Gender = false;   //male -> true, female always false
        public int Age = 0;
        public string Country = "Egypt";
        public string Governorate = "";
        public int Vaccinated = 0; //stands for number of doses taken, 0, 1, or 2


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

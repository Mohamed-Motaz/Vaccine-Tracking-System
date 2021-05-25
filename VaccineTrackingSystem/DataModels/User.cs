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
            Boolean vaccined = false;

            if (DataContainer.usersMap.ContainsKey(user.NationalID))
            {
                if (user.Vaccinated != DataContainer.usersMap[user.NationalID].Vaccinated && DataContainer.usersMap[user.NationalID].Vaccinated == 0)
                    vaccined = true;

                DataContainer.usersMap[user.NationalID] = user;

            }

            if (vaccined)
                DataContainer.currentlyWaiting.Remove(user);
        }
        public static void HandleUserDelete(User user)
        {
            DataContainer.currentlyWaiting.Remove(user);
            DataContainer.users.Remove(user);
            DataContainer.usersMap.Remove(user.NationalID);
        }
    }
}
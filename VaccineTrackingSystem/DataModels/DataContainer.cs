using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VaccineTrackingSystem.DataStructures;

namespace VaccineTrackingSystem.DataModels
{
    class DataContainer
    {
        public static string AdminPassword = "admin";
        public static CustomList<User> CurrentlyWaiting = new CustomList<User>();
        public static User CurrentUser;
        public static HashSet<String> EgyptianGovernorates = new HashSet<string>()     //Hashset in order to validate presence of item in O(1)
        {
            "Cairo", "Aswan", "Alexandria", "Aswan", "Asyut", "Beheira","Beni Suef", "Dakahlia", "Damietta",
            "Faiyum", "Gharbia", "Giza", "Ismailia", "Kafr El Sheikh", "Luxor", "Matruh", "Minya",
            "Monufia", "New Valley", "North Sinai", "Port Said", "Qalyubia", "Qena", "Red Sea",
            "Sharqia", "Sohag", "South Sinai", "Suez"
        };
        public static CustomList<User> Users = new CustomList<User>() {};
        public static Dictionary<string, User> UsersMap;   //Implemented using hashtable, so needed for fast access, search, and insert;
    }
}

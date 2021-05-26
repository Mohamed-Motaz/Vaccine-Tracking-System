using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace VaccineTrackingSystem.DataModels
{
    class DataContainer
    {
        public static string AdminPassword = "admin";
        public static List<User> Users = new List<User>();
        public static List<User> CurrentlyWaiting = new List<User>();
        public static Dictionary<string, User> UsersMap = new Dictionary<string, User>();
        public static User CurrentUser;
        public static HashSet<String> EgyptianGovernorates = new HashSet<string>()
        {
            "Cairo", "Alexandria", "Aswan", "Asyut", "Beheira","Beni Suef", "Dakahlia", "Damietta",
            "Faiyum", "Gharbia", "Giza", "Ismailia", "Kafr El Sheikh", "Luxor", "Matruh", "Minya",
            "Monufia", "New Valley", "North Sinai", "Port Said", "Qalyubia", "Qena", "Red Sea",
            "Sharqia", "Sohag", "South Sinai", "Suez"
        };

    }
}

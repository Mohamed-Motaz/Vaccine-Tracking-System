using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace VaccineTrackingSystem.DataModels
{
    class DataContainer
    {
        public static string adminPassword = "rsamak";
        public static List<User> users = new List<User>();
        public static List<User> currentlyWaiting = new List<User>();
        public static Dictionary<string, bool> usersMap = new Dictionary<string, bool>();
        public static User currentUser;
    }
}

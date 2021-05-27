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
        public static HashSet<String> EgyptianGovernorates = new HashSet<string>()
        {
            "Cairo", "Alexandria", "Aswan", "Asyut", "Beheira","Beni Suef", "Dakahlia", "Damietta",
            "Faiyum", "Gharbia", "Giza", "Ismailia", "Kafr El Sheikh", "Luxor", "Matruh", "Minya",
            "Monufia", "New Valley", "North Sinai", "Port Said", "Qalyubia", "Qena", "Red Sea",
            "Sharqia", "Sohag", "South Sinai", "Suez"
        };
        public static CustomList<User> Users = new CustomList<User>() { 
        new User()
        {
            UserName = "Mohamed Motaz",
            NationalID = "0000000000000",
            Password = "password",
            Gender = "Male",
            Age = 15,
            Governorate = "Giza",
            Vaccinated = 0
        },
        new User()
        {
            UserName = "Ali Agina",
            NationalID = "1111111111111",
            Password = "password",
            Gender = "Male",
            Age = 15,
            Governorate = "Giza",
            Vaccinated = 1
        },
        new User()
        {
            UserName = "Kareem Ezzat",
            NationalID = "1000000000000",
            Password = "password",
            Gender = "Male",
            Age = 15,
            Governorate = "Giza",
            Vaccinated = 2
        },
        new User()
        {
            UserName = "AbdelAzim",
            NationalID = "0100000000000",
            Password = "password",
            Gender = "Male",
            Age = 15,
            Governorate = "Giza",
            Vaccinated = 1
        }, 
        new User()
        {
            UserName = "Rawan Ahmed",
            NationalID = "0010000000000",
            Password = "password",
            Gender = "Female",
            Age = 15,
            Governorate = "Giza",
            Vaccinated = 1
        }, 
        new User()
        {
            UserName = "Salma Tarek",
            NationalID = "000100000000",
            Password = "password",
            Gender = "Female",
            Age = 15,
            Governorate = "Giza",
            Vaccinated = 1
        },
        };
        public static Dictionary<string, User> UsersMap = new Dictionary<string, User>() 
        { { "0000000000000", Users[0] }, {"1111111111111", Users[1]}, {"1000000000000", Users[2]},
            {"0100000000000", Users[3] }, {"0010000000000", Users[4]}, {"0001000000000", Users[5]}
        };


    }
}

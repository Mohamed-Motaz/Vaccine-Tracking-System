using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using VaccineTrackingSystem.Forms;
using VaccineTrackingSystem.DataStructures;
using VaccineTrackingSystem.DataModels;

namespace VaccineTrackingSystem
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            StartUp();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LogInForm());
        }
        static void StartUp()
        {
            Console.WriteLine(DataContainer.Users.CurrentPos);
            DataContainer.Users.Add(new User()
            {
                UserName = "Mohamed Motaz",
                NationalID = "0000000000000",
                Password = "password",
                Gender = "Male",
                Age = 15,
                Governorate = "Giza",
                Vaccinated = 0,
                Country = "Egypt"
            }); Console.WriteLine(DataContainer.Users.CurrentPos);


            DataContainer.Users.Add(new User()
            {
                UserName = "Ali Agina",
                NationalID = "1111111111111",
                Password = "password",
                Gender = "Male",
                Age = 15,
                Governorate = "Giza",
                Vaccinated = 1,
                Country = "Egypt"
            });
            DataContainer.Users.Add(new User()
            {
                UserName = "Kareem Ezzat",
                NationalID = "1000000000000",
                Password = "password",
                Gender = "Male",
                Age = 15,
                Governorate = "Giza",
                Vaccinated = 2,
                Country = "Egypt"
            });
            DataContainer.Users.Add(new User()
            {
                UserName = "AbdelAzim",
                NationalID = "0100000000000",
                Password = "password",
                Gender = "Male",
                Age = 15,
                Governorate = "Giza",
                Vaccinated = 1,
                Country = "Egypt"
            });
            DataContainer.Users.Add(new User()
            {
                UserName = "Rawan Ahmed",
                NationalID = "0010000000000",
                Password = "password",
                Gender = "Female",
                Age = 15,
                Governorate = "Giza",
                Vaccinated = 2,
                Country = "Egypt"
            });
            DataContainer.Users.Add(new User()
            {
                UserName = "Salma Tarek",
                NationalID = "0001000000000",
                Password = "password",
                Gender = "Female",
                Age = 15,
                Governorate = "Giza",
                Vaccinated = 0,
                Country = "Egypt"
            });
            Console.WriteLine("in startup " + DataContainer.Users.CurrentPos);
            DataContainer.UsersMap = new Dictionary<string, User>()
            { { "0000000000000", DataContainer.Users[0] }, {"1111111111111", DataContainer.Users[1]}, {"1000000000000", DataContainer.Users[2]},
                {"0100000000000", DataContainer.Users[3] }, {"0010000000000", DataContainer.Users[4]}, {"0001000000000", DataContainer.Users[5]}
            };
            foreach(User user in DataContainer.Users)
            {
                if (user.Vaccinated == 0)
                    DataContainer.CurrentlyWaiting.Add(user);
            }
        }
    }
}

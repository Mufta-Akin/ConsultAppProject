using System;
using System.Text;
using System.Collections.Generic;

using Consultation.Data.Models;

namespace Consultation.Data.Services
{
    public static class Seeder
    {
        // use this class to seed the database with dummy 
        // test data using an IUserService 
         public static void Seed(IUserService _user, PracticeService _svc, PatientService _pat)
        {
            _svc.Initialise();

            // create practice adminstrator
            var admin = _user.AddUser("Practice Manager","manager@mail.com", "manager", Role.Practice);

            // add patients
            var pat1 = _svc.AddPatient("Jameses Conneore", "27 Blammer Road, Georgetown", "connore@mail.net","password", "+1 2304564789", new DateTime(2000,1,1));
            var pat2 = _svc.AddPatient("Marty Bluffy", "7 Gainsville Avenue, Senate House", "marty@mail.com", "password", "+241 2467326493", new DateTime(1945,4,11));
            var pat3 = _svc.AddPatient("Gracie Tempper", "900 Briton Lane, Birminghan", "G_Temper@gomail.eu", "password", "+44 4905342773", new DateTime(1972,1,1));
            var pat4 = _svc.AddPatient("Drew Horne", "Westin House, apt 23, Luton", "flipper22@mail.uk", "password", "+44 3425239403", new DateTime(1991,1,1));
            var pat5 = _svc.AddPatient("Kong Leonne", "Unit 7 Ash Road Apartment, Derry", "Kong@goodmail.com", "password", "+23 8063788273", new DateTime(2010,1,1));
            var pat6 = _svc.AddPatient("Henrt Claimmer", "8804 Flaneggan Road, apt 2, London", "Claimmer.H@mail.net", "password", "03564495748", new DateTime(1964,1,1));
            var pat7 = _svc.AddPatient("Daniel Leopez", "Central Parkway, Apt 80, Oxford", "Dan@binmail.com", "password", "06375465577", new DateTime(1983,1,1));
            var pat8 = _svc.AddPatient("Joanna Salome", "3454 Highway 22nd Bypass, Antrim", "Salome_J@Salome.com", "password", "0383458734650", new DateTime(2010,1,1));

            var ailment1 = _pat.AddAilment(pat1.Id, "needing to pee more frequently");
            var ailment2 = _pat.AddAilment(pat1.Id, "needing to rush to the toilet");
            var ailment3 = _pat.AddAilment(pat1.Id, "difficulty in starting to pee");
            var ailment4 = _pat.AddAilment(pat1.Id, "weak flow");
            var ailment5 = _pat.AddAilment(pat1.Id, "feeling that bladder has not emptied fully");
            var ailment6 = _pat.AddAilment(pat1.Id, "blood in urine");


            // add doctors

            // add symptoms

        }
    }
}

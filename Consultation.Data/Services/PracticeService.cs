using System;
using System.Linq;
using System.Collections.Generic;

using Consultation.Data.Models;
using Consultation.Data.Security;
using Consultation.Data.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Consultation.Data.Services
{
    public class PracticeService
    {
        private readonly DatabaseContext  ctx;

        public PracticeService()
        {
            ctx = new DatabaseContext(); 
        }

        public void Initialise()
        {
           ctx.Initialise(); 
        }
       
        // get the patient with the specified patient id
        public Patient GetPatientById(int patientId)
        {
            return ctx.Patients
                     .Include(pat => pat.Ailments)
                     .Include(pat =>pat.User)
                     .FirstOrDefault(pat => pat.Id == patientId);
        }

        // add a new patient and associated user account 
        public Patient AddPatient(string name, string address, string email, string password, string mobile, DateTime dob)
        {
            // check if email is already in use by another patient
            var existing = GetPatientByEmail(email);
            if (existing != null)
            {
                return null; // email in use so we cannot create patient
            }
            // proceed to create new patient, email is unique.
            var pat = new Patient()
            {
                //  Id is set automatically by the database
                Address = address,
                Mobile = mobile,
                Dob = dob,

                // add patient user account
                User = new User {Name = name, Email = email, Password = Hasher.CalculateHash(password), Role = Role.Patient }
            };
            ctx.Patients.Add(pat);
            ctx.SaveChanges(); // write to database
            return pat; // return newly added patient
        }

        public Patient GetPatientByEmail(string email)
        {
            return ctx.Patients.FirstOrDefault(pat => pat.User.Email == email);
        }

        public Patient UpdatePatient(Patient updated)
        {
            // verify that the patient exists
            var patient = GetPatientById(updated.Id);
            if (patient == null)
            {
                return null;
            }
            // update the details of the patient retrieved and save
            patient.Address = updated.Address;
            patient.Mobile = updated.Mobile;
            patient.Dob = updated.Dob;

            patient.User.Name = updated.User.Name;          
            patient.User.Email = updated.User.Email;
            patient.User.Password = Hasher.CalculateHash(updated.User.Password);

            ctx.SaveChanges(); // write to database
            return patient;
        }

        // delete the specified patient and related user
        public bool DeletePatient(int id)
        {
            var pat = GetPatientById(id);
            if (pat == null)
            {
                return false;
            }
            ctx.Users.Remove(pat.User);
            ctx.Patients.Remove(pat);
            ctx.SaveChanges(); // write to database
            return true;
        }


    }


}
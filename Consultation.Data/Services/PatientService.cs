using System;
using System.Linq;
using System.Collections.Generic;

using Consultation.Data.Models;
using Consultation.Data.Security;
using Consultation.Data.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Consultation.Data.Services
{
    public class PatientService
    {
        private readonly DatabaseContext  ctx;

        public PatientService()
        {
            ctx = new DatabaseContext(); 
        }

        // Get the patient with the specified user id
        public Patient GetPatientByUserId(int userId)
        {
            return ctx.Patients
                     .Include(pat => pat.Ailments)
                     .Include(pat =>pat.User)
                     .FirstOrDefault(pat => pat.User.Id == userId);
        }

        // get the patient with the specified patient 
        public Patient GetPatientById(int patientId)
        {
            return ctx.Patients
                     .Include(pat => pat.Ailments)
                     .Include(pat =>pat.User)
                     .FirstOrDefault(pat => pat.Id == patientId);
        }

        public Patient UpdatePatient(Patient updated)
        {
            // verify that the patient exists
            var patient = GetPatientById(updated.Id);
            if (patient == null)
            {
                return null;
            }
            // update the details of the patient retrieved and save - can limit what the patient can update
            patient.Address = updated.Address;
            patient.Mobile = updated.Mobile;
            patient.Dob = updated.Dob;

            patient.User.Name = updated.User.Name;          
            patient.User.Email = updated.User.Email;
            patient.User.Password = Hasher.CalculateHash(updated.User.Password);

            ctx.SaveChanges(); // write to database
            return patient;
        }

        public Ailment AddAilment(int patientId, string complaint)
        {
            var patient = GetPatientById(patientId);
            if (patient == null)
            {
                return null;
            }
            var ailment = new Ailment { PatientId = patientId, Complaint = complaint };
            patient.Ailments.Add(ailment);
            ctx.SaveChanges();
            return ailment;
        }


    }


}
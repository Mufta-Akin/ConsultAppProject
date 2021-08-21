using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Consultation.Data.Models;
using Consultation.Data.Services;
using Consultation.Web.ViewModels;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;

namespace Consultation.Web.Controllers
{
    [Authorize(Roles = "Patient")]
    public class PatientController : BaseController
    {
        private PatientService _svc;

        public PatientController(PatientService svc)
        {
            _svc = svc;
        }

        // GET: Current patient Dashboard
        public IActionResult Index()
        {
            // dashboard for patient   
            return View();
        }

        // GET: Patients/Details
        public IActionResult Details()
        {           
            // obtain id from currently logged in user (patient)
            var id = GetSignedInUserId(); // method in base controller
          
            // retrieve the patient with specified id from the service
            var pat = _svc.GetPatientByUserId(id);
            if (pat == null)
            {
                Alert("Patient Not Found", AlertType.warning);
                return RedirectToAction(nameof(Index));
            }
            return View(pat);
        }

        
        // GET /patient/edit
        public IActionResult Edit()
        {
            // obtain id from currently logged in user (patient)
            var id = GetSignedInUserId(); // method in base controller
            
            // retrieve the patient with specified id from the service
            var pat = _svc.GetPatientByUserId(id);
            if (pat == null)
            {
                Alert($"No such patient {id}", AlertType.warning);
                return RedirectToAction(nameof(Index));
            }

            // pass patient to view for editing
            return View(pat);
        }


        // POST: Patients/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, [Bind("Id,Name,Address,Email,Mobile,Age,Password")] Patient pat)
        {
            
            // validate patient
            if (ModelState.IsValid)
            {
                // pass data to service to update

                _svc.UpdatePatient(pat);
                Alert("Patient details saved", AlertType.info);

                return RedirectToAction(nameof(Index));
            }

            // redisplay the form for editing as validation errors
            return View(pat);
        }


    }
}

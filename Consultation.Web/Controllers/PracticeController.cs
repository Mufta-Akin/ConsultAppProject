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
    [Authorize(Roles = "Practice")]
    public class PracticeController : BaseController
    {
        private PracticeService _svc;

        public PracticeController(PracticeService svc)
        {
            _svc = svc;
        }

        // GET: Current patient Dashboard
        public IActionResult Index()
        {
            // dashboard for practice   
            return View();
        }


    }
}

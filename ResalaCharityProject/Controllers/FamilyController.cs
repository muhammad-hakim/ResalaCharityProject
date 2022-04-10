using Microsoft.AspNetCore.Mvc;
using ResalaCharityProject.Models;
using ResalaCharityProject.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ResalaCharityProject.Controllers
{
    public class FamilyController : Controller
    {
        [HttpGet]
        public IActionResult GetResearchRequests()
        {
            //TODO: List research requests
            return View();
        }

        [HttpGet]
        public IActionResult CreateResearchRequest()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateResearchRequest(ResearchRequestVM researchRequest)
        {
            //TODO: call to service to create request
            return null;
        }

        [HttpGet]
        public IActionResult GetFamilyProfile(int id)
        {
            //TODO: return full family profile
            return View();
        }

        [HttpGet]
        public IActionResult CreateFamilyProfile()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateFamilyProfile(CreateFamilyProfileVM familyProfile)
        {
            //TODO: call a service to call family profile
            return null;
        }

        [HttpGet]
        public IActionResult UpdateFamilyProfile(int id)
        {
            //TODO: return family profile in edit mode
            return View();
        }

        [HttpPost]
        public IActionResult UpdateFamilyProfile()
        {
            return null;
        }
    }
}

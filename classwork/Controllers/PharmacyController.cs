using classwork.Model;
using classwork.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace classwork.Controllers
{
    public class PharmacyController : Controller
    {

        public IActionResult Drug()
        {
            List<Drug> drugs = new List<Drug>
            {
                new Drug{Name = "Paracetamol", Country = "Sweden"},
                new Drug{Name = "Cardiomagnil", Country = "USA"},
                new Drug{Name = "Ketorol", Country = "Russia"},
                new Drug{Name = "Metoproklamid", Country = "Germany"},
                new Drug{Name = "Reopirin", Country = "Spain"}
            };

            List<DrugType> drugtypes = new List<DrugType>
            {
                new DrugType{Type = "Heart", Amount = 105},
                new DrugType{Type = "Stomach", Amount = 69},
                new DrugType{Type = "Psychotropic", Amount = 96}
            };

            var model = new PharmacyIndexViewModel { Drugs = drugs, DrugTypes = drugtypes };


            return View(model);
        }
        public IActionResult DrugType()
        {
            return View();
        }
    }
}

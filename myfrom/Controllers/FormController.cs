using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using myfrom.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace myfrom.Controllers
{
    public class FormController : Controller
    {
        // GET: /<controller>/
        [HttpGet]
        public IActionResult Insert()
        {
            FormModel formModel = new FormModel();
            return View(formModel);
        }
        [HttpPost]
        public IActionResult Insert(FormModel formModel)
        {
            if (ModelState.IsValid)
            {
                return View(formModel);
            }
            else
            {
                ModelState.AddModelError("Error", "Invalid data");
                return View(formModel);

            }

        }
    }
}

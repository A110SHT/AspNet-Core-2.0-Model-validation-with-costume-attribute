using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myfrom.Models
{
    public class Country
    {
        public List<SelectListItem> ListCountry()
        {
            List<SelectListItem> Lstcountry = new List<SelectListItem>
            {
                 new SelectListItem() { Text = "--Select Country--", Value=string.Empty, Selected = true },
                new SelectListItem() { Text = "USA", Value = "USA", Selected = false },
                new SelectListItem() { Text = "Canada", Value = "Canada", Selected = false },
                new SelectListItem() { Text = "Nepal", Value = "Nepal", Selected = false },
                new SelectListItem() { Text = "China", Value = "China", Selected = false },
                new SelectListItem() { Text = "Japan", Value = "Japan", Selected = false },
                new SelectListItem() { Text = "Qatar", Value = "Qatar", Selected = false }
            };
            return Lstcountry;

        }
    }
}

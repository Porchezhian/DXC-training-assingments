using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CascadedDropDown.Models;

namespace CascadedDropDown.Controllers
{
    public class DropdownController : Controller
    {
        // GET: Dropdown
        public ActionResult Index()
        {
            tblCountry con = new tblCountry();
            CountriesEntities entity = new CountriesEntities();
            ViewBag.countries = new SelectList(entity.tblCountries, "country_id", "country");
            ViewBag.states = new List<SelectListItem>(){ 
                new SelectListItem{Text="", Value=""} 
            }; 
            return View(con);
        }

        [HttpPost]
        public ActionResult Index(tblCountry con)
        {
            CountriesEntities entity = new CountriesEntities();
            ViewBag.countries = new SelectList(entity.tblCountries, "country_id", "country");
            ViewBag.states = new SelectList(entity.tblStates.Where(x => x.country_id.ToString() == con.country ), "state_id", "state");
            return View();
        }
    }
}
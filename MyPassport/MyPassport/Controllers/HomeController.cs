using MyPassport.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyPassport.Controllers
{
    public class HomeController : Controller
    {
        public static List<country> FetchAll()
        {
            var countriesVM = new List<country>();
            using (var db = new PassportEntities())
            {
                List<country> countries = db.countries.ToList();
                foreach (var country in countries)
                {
                    var countryVM = new country();
                    countryVM.Name = country.Name;
                    countryVM.Official_Name = country.Official_Name;
                    countryVM.Continent = country.Continent;
                    countryVM.Capital = country.Capital;
                    countryVM.Largest_City = country.Largest_City;
                    countryVM.Most_Spoken_Language = country.Most_Spoken_Language;
                    countryVM.Demonym = country.Demonym;
                    countryVM.HoS_Title = country.HoS_Title;
                    countryVM.Head_of_State = country.Head_of_State;
                    countryVM.HoS_Picture = country.HoS_Picture;
                    countryVM.HoG_Title = country.HoG_Title;
                    countryVM.Head_of_Government = country.Head_of_Government;
                    countryVM.HoG_Picture = country.HoG_Picture;
                    countryVM.Population = country.Population;
                    countryVM.Currency = country.Currency;
                    countryVM.Anthem = country.Anthem;
                    countryVM.AnthemHtml = country.AnthemHtml;
                    countryVM.Globe = country.Globe;
                    countryVM.Flag = country.Flag;
                    countryVM.CoA = country.CoA;
                    countryVM.Acceptables = country.Acceptables;
                    countriesVM.Add(countryVM);
                }

            }
            return countriesVM;
        }
        public ActionResult Index()
        { 
            return View();
        }

        public ActionResult Country(string Name)
        {
            if (Name == null)
            {
                return View();
            }
            else
            {
                var db = FetchAll();
                country selected = db.Single(x => x.Name == Name);
                return View(selected);
            }
           
        }
    }
}
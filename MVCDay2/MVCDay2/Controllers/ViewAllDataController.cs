using Microsoft.AspNetCore.Mvc;
using MVCDay2.Models;

namespace MVCDay2.Controllers
{
    public class ViewAllDataController : Controller
    {
        Drugs drugsList = new Drugs();
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ViewAllData() { 
        
           List<Drug> drugs = drugsList.GetAll();
            return View("ViewAllData", drugs);
        
        }
        public IActionResult Details(int id) {

            Drug drug = drugsList.Details(id);

            return View("Details", drug);
        
        
        }

    }
}

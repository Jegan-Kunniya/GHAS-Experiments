using Microsoft.AspNetCore.Mvc;
using GhasExperiments.Models;

namespace GhasExperiments.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var model = new SampleModel
            {
                Id = 1,
                Name = "Sample Name",
                Description = "This is a sample description."
            };
            return View(model);
        }
    }
}
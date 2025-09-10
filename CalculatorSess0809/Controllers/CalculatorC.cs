using Microsoft.AspNetCore.Mvc;
using CalculatorSess0809.Models;

namespace MvcCalculatorApp.Controllers
{
    public class CalculatorController : Controller
    {
        [HttpGet]
        public IActionResult CalculatorV()
        {
            return View("CalculatorV");
        }

        
        [HttpPost]
        public IActionResult Calculate(Calculator model, string action)
        {
            if (action == "Sum")
            {
                model.Result = model.Number1 + model.Number2;
            }
            else if (action == "Difference")
            {
                model.Result = model.Number1 - model.Number2;
            }

            return View("CalculatorV", model);
        }
    }
}
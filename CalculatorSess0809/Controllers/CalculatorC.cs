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
            switch (action)
            {
                case "Sum":
                    model.Result = model.Number1 + model.Number2;
                    break;
                case "Difference":
                    model.Result = model.Number1 - model.Number2;
                    break;
                case "Multiply":
                    model.Result = model.Number1 * model.Number2;
                    break;
                case "Divide":
                    model.Result = model.Number1 / model.Number2;
                    break;
                case "Power":
                    model.Result = (float)Math.Pow(model.Number1, model.Number2); 
                    break;
                case "root":
                    model.Result = (int)Math.Pow(model.Number1, 1.0 / model.Number2);
                    break;
                case "CalculateEquation":
                    //looking for "^"
                    for (int i = 0; i < model.Equation.Length; i++)
                    {
                        if(model.Equation[i] = "^")
                        {

                        }
                    }
                    break;
            }
            return View("CalculatorV", model);
        }
    }
}
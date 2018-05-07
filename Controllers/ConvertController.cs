using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Assignment5.Models;


namespace Assignment5.Controllers
{
    public class ConvertController : Controller
    {
        public IActionResult Convert(Converter convert)
        {

            switch (convert.numconvert)
            {
                case "mph to kmh":
                    convert.result = convert.num * 1.6;

                    break;

                case "kmh to mph":
                convert.result = convert.num / 1.6;
                    break;

                case "Celsius to Fahrenheit":
                convert.result = convert.num *1.8 +32;
                    break;

                case "Fahrenheit to Celsius":
                convert.result = (convert.num -32) /1.8;
                    break;
            }
            return View(convert);
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

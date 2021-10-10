using System;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.CodeAnalysis.CSharp;

namespace RazorCurrencyConverter.Pages
{
    public class CurrencyConverterModel : PageModel
    {
        [BindProperty]
        public String ConvertFrom { get; set; }

        public const double USD = 1.36;

        public void OnPost()
        {
            var value = Request.Form["Value"];
                double convertedMoney = ConvertAmount(Convert.ToDouble(value));
                ViewData["Result"] = $"You have {convertedMoney} in USD";           
        }
        
        /// <summary>
        /// Input amount from the user and then return the result of the equation from the constant 
        /// </summary>
        /// <param name="InputAmount"></param>
        /// <returns></returns>
        public double ConvertAmount(double inputAmount)
        {
            var result = inputAmount * USD; 
            return result; 
        }
    }
}



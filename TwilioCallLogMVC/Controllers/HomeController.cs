using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using Twilio;

namespace TwilioCallLogMVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            public IActionResult Index(string phoneNumber)
{
    // Instantiate a new Twilio Rest Client
    var client = new TwilioRestClient("SK8e575582f77329e9bdf27778a7103e8f", "RG1vieNqBKVnOp9bl5ttJ3kvhBUVlLnK");
    
    // Select all calls from my account based on a phoneNumber
    var calls = client.ListCalls(new CallListRequest(){To = phoneNumber});

    // Check for any exceptions
    if (calls.RestException != null)
    {
    throw new FormatException(calls.RestException.Message);
    }

    return View(calls.Calls);
}
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}

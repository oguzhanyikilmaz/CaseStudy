using CaseStudy.Business.Abstract;
using CaseStudy.Business.Models;
using CaseStudy.Web.Models;
using CaseStudy.Web.Refit.Dependency;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace CaseStudy.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private IReceiptService _receiptService;

        public HomeController(ILogger<HomeController> logger, IReceiptService receiptService)
        {
            _logger = logger;
            _receiptService = receiptService;
        }

        public  IActionResult Index()
        {
            var response = _receiptService.ConvertJsonReceiptModel();

            
            if (response != null)
            {
                return View(response);
            }
            else
            {
                return RedirectToAction("Error");
            }

        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ISinglton singlton;
        private readonly IScoped scoped;
        private readonly ITransient transient;
        private readonly SenterService senterService;
        private readonly TimeService timeService;
       
        public HomeController(ILogger<HomeController> logger,
                              ISinglton singlton,
                              IScoped scoped,
                              ITransient transient,
                              SenterService senterService,
                              TimeService timeService)                   
        {
            _logger = logger;
            this.singlton = singlton;
            this.scoped = scoped;
            this.transient = transient;
            this.senterService = senterService;
            this.timeService = timeService;
        }

        public IActionResult Index()
        {
            ViewData["Singleton"] = this.singlton.GetCounter();
            ViewData["Scoped"] = this.scoped.GetCounter();
            ViewData["Transient"] = this.transient.GetCounter();
            ViewData["SenderSMS"] = this.senterService.SentBySms();
            ViewData["SenderEmail"] = this.senterService.SentByEmail();
            ViewData["SenterTime"] = this.senterService.GetTime();
            ViewData["SenterId"] = this.senterService.GetId();
            ViewData["Time"] = this.timeService.localDate;
            ViewData["Id"] = this.timeService.Id;
            return View();
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

using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FormDemoAmFreitag.Controllers.dtos;
using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace FormDemoAmFreitag.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class JobDashboardController
        : ControllerBase
    {
       

        private readonly ILogger<JobDashboardController> _logger;

        public JobDashboardController(ILogger<JobDashboardController> logger)
        {
            _logger = logger;
        }

        [HttpGet("")]
        public String Version()
        {
            return "1.0.0";
        }

        [HttpGet("/forms/job-dashboard")]
        [Produces("application/json")]
        public JobDashboardForm GetFormData()
        {
            IList<SelectListItem> items = new List<SelectListItem>();
            items.Add(new SelectListItem { Text = "Bitte wählen", Value = "" });
            items.Add(new SelectListItem { Text = "Apfel", Value = "0" });
            items.Add(new SelectListItem { Text = "Birne", Value = "1" });
            items.Add(new SelectListItem { Text = "Banane", Value = "2" });

            IList<UseCaseConfig> configs = new List<UseCaseConfig>();
            configs.Add(new UseCaseConfig { key = "", value = "Bitte wählen" });
            configs.Add(new UseCaseConfig { key = "0", value = "Nagel" });
            configs.Add(new UseCaseConfig { key = "1", value = "Schraube" });
            configs.Add(new UseCaseConfig { key = "2", value = "Niete" });


            JobDashboardForm result = new JobDashboardForm();
            result.useCaseConfigs = configs;
            result.items = items;
            result.Betrachtungstag = DateTime.Now;
            result.ErrorMessage = null;
            result.Headline = "Eine tolle Headline";
            result.LogHint = "Ein Loghint";
            return result;
        }

        [HttpPost]
        [Consumes("application/json")]
        public void RunJob(JobStarterDto jobStarter)
        {
            // Valide, nicht fachliche Prüfung
            Console.WriteLine(jobStarter);
        } 


    }
}

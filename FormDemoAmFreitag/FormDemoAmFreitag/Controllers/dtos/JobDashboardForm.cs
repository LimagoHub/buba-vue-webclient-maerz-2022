using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FormDemoAmFreitag.Controllers.dtos
{
    public class JobDashboardForm
    {
        public string Headline { get; set; }
        public string LogHint { get; set; }

        public string ErrorMessage { get; set; }

        public DateTime Betrachtungstag { get; set; }

        public IList<UseCaseConfig> useCaseConfigs { get; set; }

        public IList<SelectListItem> items { get; set; } // abwärtskompatibel

    }
}

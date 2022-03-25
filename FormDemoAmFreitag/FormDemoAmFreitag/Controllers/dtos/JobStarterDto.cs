using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FormDemoAmFreitag.Controllers.dtos
{
    public class JobStarterDto 
    {
        public DateTime  Betrachtungstag { get; set; }
        public string UseCaseConfig { get; set; }

        public override string ToString()
        {
            return $"{nameof(Betrachtungstag)}: {Betrachtungstag}, {nameof(UseCaseConfig)}: {UseCaseConfig}";
        }
    }
}

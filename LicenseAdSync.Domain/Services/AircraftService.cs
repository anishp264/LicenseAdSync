using LicenseAdSync.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LicenseAdSync.Domain.Services
{
    public class AircraftService : IAircraft
    {
        public string GetAircraft()
        {
            return "B787-10 Dreamliner";
        }
    }
}

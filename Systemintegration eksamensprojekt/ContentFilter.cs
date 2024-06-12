using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Systemintegration_eksamensprojekt
{
    internal class ContentFilter
    {
        public static EUCCID filter(EUCCID data)
        {
            data.Gender = null;
            data.County = null;
            data.BirthCountry = null;
            data.CurrentLivingInCountry = null;
            return data;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Systemintegration_eksamensprojekt
{
    internal class Enricher
    {
        public static CPR enrich(CPR data)
        {
            data.Postnummer = "8270"; //Her bør der laves et kald til en api eller anden form for service hvor man kan få en bys postnummer ud fra bynavn og gade
            // det næste data bør anskaffes ved indtastning fra bruger på en hjemmeside eller noget lignende, jeg sætter det bare for ikke at overkomplikere det
            data.Ægteskabeligstatus = "Married";
            data.ÆgtefælleCprNr = "05101991-537512";
            data.BørnsCprNr = "";
            data.ForældresCprNr = "01101963-125475, 15091961-435622";
            data.LægeCvrNr = "10150817";
            return data;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Systemintegration_eksamensprojekt
{
    internal class Translator
    {
        public static CPR translate(EUCCID data)
        {
            CPR CPR = new CPR
            {
                Fornavn = data.ChristianName,
                Efternavn = data.FamilyName,
                CprNr = data.EuCcid,
                Adresse1 = data.StreetNumber + ", " + data.ApartmentNumber,
                By = data.City,
            };
            return CPR;
        }
    }
}

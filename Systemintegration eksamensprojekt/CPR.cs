using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Systemintegration_eksamensprojekt
{
    public class CPR
    {
        public string Fornavn { get; set; }
        public string Efternavn { get; set; }
        public string CprNr { get; set; }
        public string Adresse1 { get; set; }
        public string Adresse2 { get; set; }
        public string Postnummer { get; set; }
        public string By { get; set; }
        public string Ægteskabeligstatus { get; set; }
        public string ÆgtefælleCprNr { get; set; }
        public string BørnsCprNr { get; set; }
        public string ForældresCprNr { get; set; }
        public string LægeCvrNr { get; set; }
        public override string ToString()
        {
            return $"Fornavn: {Fornavn}, Efternavn: {Efternavn}, CprNr: {CprNr}, " +
                   $"Adresse1: {Adresse1}, Adresse2: {Adresse2}, Postnummer: {Postnummer}, By: {By}, " +
                   $"Ægteskabeligstatus: {Ægteskabeligstatus}, ÆgtefælleCprNr: {ÆgtefælleCprNr}, " +
                   $"BørnsCprNr: {BørnsCprNr}, ForældresCprNr: {ForældresCprNr}, LægeCvrNr: {LægeCvrNr}";
        }

    }

}

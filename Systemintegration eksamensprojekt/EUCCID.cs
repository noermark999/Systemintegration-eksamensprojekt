using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Systemintegration_eksamensprojekt
{
    public class EUCCID
    {
        public string ChristianName { get; set; }
        public string FamilyName { get; set; }
        public string EuCcid { get; set; }
        public string Gender { get; set; }
        public string StreetNumber { get; set; }
        public string ApartmentNumber { get; set; }
        public string County { get; set; }
        public string City { get; set; }
        public string BirthCountry { get; set; }
        public string CurrentLivingInCountry { get; set; }
        public override string ToString()
        {
            return $"ChristianName: {ChristianName}, FamilyName: {FamilyName}, EuCcid: {EuCcid}, " +
                   $"Gender: {Gender}, StreetNumber: {StreetNumber}, ApartmentNumber: {ApartmentNumber}, " +
                   $"County: {County}, City: {City}, BirthCountry: {BirthCountry}, " +
                   $"CurrentLivingInCountry: {CurrentLivingInCountry}";
        }
    }

}

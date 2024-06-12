using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Messaging;

namespace Systemintegration_eksamensprojekt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EUCCID EUCCIDTest = new EUCCID
            {
                ChristianName = "Lars",
                FamilyName = "Hansen",
                EuCcid = "09041991-587090",
                Gender = "Male",
                StreetNumber = "Langelandsgade 12",
                ApartmentNumber = "3.5",
                County = "Midtjylland",
                City = "Aarhus",
                BirthCountry = "DK",
                CurrentLivingInCountry = "DK"
            };

            Console.WriteLine("EUCCID objekt inden content filer:");
            Console.WriteLine(EUCCIDTest.ToString());
            Console.WriteLine();

            EUCCID EUCCIDTestFiltered = ContentFilter.filter(EUCCIDTest);

            Console.WriteLine("EUCCID objekt efter content filter:");
            Console.WriteLine(EUCCIDTestFiltered.ToString());
            Console.WriteLine();

            CPR cprTest = Translator.translate(EUCCIDTestFiltered);

            Console.WriteLine("CPR objekt inden enricher:");
            Console.WriteLine(cprTest.ToString());
            Console.WriteLine();

            CPR cprTestEnriched = Enricher.enrich(cprTest);

            Console.WriteLine("CPR objekt efter enricher:");
            Console.WriteLine(cprTest);
            Console.WriteLine();

            Console.WriteLine("CPR objekt sendes nu ud i message queue hvor den kan blive hentet og registreret");

            MessageQueue messageQueue = null;
            if (MessageQueue.Exists(@".\Private$\CPRToBeRegistered"))
            {
                messageQueue = new MessageQueue(@".\Private$\CPRToBeRegistered");
                messageQueue.Label = "CPRToBeRegistered Queue";
            }
            else
            {
                // Create the Queue
                MessageQueue.Create(@".\Private$\CPRToBeRegistered");
                messageQueue = new MessageQueue(@".\Private$\CPRToBeRegistered");
                messageQueue.Label = "CPRToBeRegistered Queue";
            }
            Message message = new Message();
            message.Body = cprTestEnriched;
            messageQueue.Send(message);
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas
{
    public class Taxi
    {
        //properties
        public string DriverName { get; set; }
        public bool OnDuty { get; set; }
        public float NumPassenger { get; set; }

        //methot
        public void TaxiInfo()
        {
            Console.WriteLine("Drive Name: {0}", DriverName);
            Console.WriteLine("On Duty: {0}", OnDuty);
            Console.WriteLine("Number of Passenger: {0}\n", NumPassenger);
        }

        public void PickUpPassenger()
        {
            Console.WriteLine("{0} sedang menjemput penumpang", DriverName);
        }
        public void DropOffPassenger()
        {
            Console.WriteLine("{0} selesai mengantar penumpang", DriverName);
        }
    }
}

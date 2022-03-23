using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas
{
    class Program
    {
        static void Main(string[] args)
        {
            //membuat objek dari class mahasiswa
            Taxi taxi = new Taxi();

            // set nilai properties objek saya dan kamu
            taxi.DriverName = "Lukman";
            taxi.OnDuty = true;
            taxi.NumPassenger = 10;

            //memanggil method
            taxi.TaxiInfo();
            taxi.PickUpPassenger();
            taxi.DropOffPassenger();

            Console.ReadKey();

        }
    }
}

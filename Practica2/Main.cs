using static System.Collections.Specialized.BitVector32;

namespace Practice1
{
    internal class Program
    {

        static void Main()
        {
            PoliceStation policeStation = new PoliceStation();
            City city = new City(policeStation);
            Console.WriteLine("City and Police Station created.");

            Taxi taxi1 = new Taxi("0001 AAA");
            Taxi taxi2 = new Taxi("0002 BBB");
            city.RegisterTaxiLicence(taxi1);
            city.RegisterTaxiLicence(taxi2);

            SpeedRadar radar1 = new SpeedRadar();
            SpeedRadar radar2 = new SpeedRadar();
            PoliceCar policeCar1 = new PoliceCar("0001 CNP", radar1);
            PoliceCar policeCar2 = new PoliceCar("0002 CNP");
            PoliceCar policeCar3 = new PoliceCar("0003 CNP", radar2);          

            policeStation.RegisterPolice(policeCar1);
            policeStation.RegisterPolice(policeCar2);
            policeStation.RegisterPolice(policeCar3);

            taxi1.StartRide();
            policeCar2.StartPatrolling();
            policeCar2.UseRadar(taxi1);

            policeCar1.StartPatrolling();
            policeCar3 .StartPatrolling();

            taxi2.StartRide();
            policeCar1.UseRadar(taxi2);

            policeStation.TriggerAlert(taxi1.GetPlate(), policeCar1);

            city.RemoveTaxiLicence(taxi1.GetPlate());

            policeCar1.PrintRadarHistory();
        }
    }
}
    


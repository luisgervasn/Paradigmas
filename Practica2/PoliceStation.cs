namespace Practice1
{
    class PoliceStation
    {
        private List<PoliceCar> policeCars;
        private string lastAlert;

        public PoliceStation()
        {
            policeCars = new List<PoliceCar>();
            lastAlert = string.Empty;
        }

        public void RegisterPolice(PoliceCar policeCar)
        {
            policeCars.Add(policeCar);
            Console.WriteLine($"Police car {policeCar} registered.");
        }

        public void TriggerAlert(string vehiclePlate, PoliceCar reportingCar)
        {
            lastAlert = vehiclePlate;
            Console.WriteLine($"ALERT: Vehicle {vehiclePlate} reported by Police car {reportingCar}. Notifying all police cars...");

            foreach (var car in policeCars)
            {
                if (car != reportingCar)
                {
                    car.StartPersecuting(vehiclePlate);
                }
            }
        }

        public void ShowRegisteredPolice()
        {
            Console.WriteLine("Registered Police Cars:");
            foreach (var car in policeCars)
            {
                Console.WriteLine(car);
            }
        }
    }
}

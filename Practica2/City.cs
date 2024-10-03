namespace Practice1
{
    class City
    {
        private PoliceStation policeStation;
        private List<Taxi> taxisRegistered;

        public City()
        {
            policeStation = new PoliceStation();
            taxisRegistered = new List<Taxi>();
        }

        public void RegisterTaxiLicence(Taxi taxi)
        {
            taxisRegistered.Add(taxi);
            Console.WriteLine($"Taxi with licence {taxi.GetPlate()} registered.");
        }

        public void RemoveTaxiLicence(string plate)
        {
            taxisRegistered.RemoveAll(t => t.GetPlate() == plate);
            Console.WriteLine($"Taxi with licence {plate} removed.");
        }

        public void ShowRegisteredTaxis()
        {
            Console.WriteLine("Registered Taxis:");
            foreach (var taxi in taxisRegistered)
            {
                Console.WriteLine(taxi);
            }
        }
    }
}

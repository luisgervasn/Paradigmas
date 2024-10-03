namespace Practice1
{
    class Scooter: Vehicle
    {
        private const string typeOfVehicle = "Scooter";

        public Scooter() : base(typeOfVehicle, "NO_PLATE")
        {
            SetSpeed(25.0f);
        }

        public void StartRide()
        {
            SetSpeed(25.0f);
            Console.WriteLine(WriteMessage("starting a ride."));
        }
        public void StopRide()
        {
            SetSpeed(0.0f);
            Console.WriteLine(WriteMessage("stoping a ride."));
        }
    }
}

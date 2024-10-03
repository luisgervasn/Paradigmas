namespace Practice1
{
    class PoliceCar : Vehicle
    {
        private const string typeOfVehicle = "Police Car"; 
        private bool isPatrolling;
        private bool isPersecuting;
        private SpeedRadar speedRadar;

        public PoliceCar(string plate, SpeedRadar radar=null) : base(typeOfVehicle, plate)
        {
            isPatrolling = false;
            isPersecuting = false;
            speedRadar = radar;
        }

        public void UseRadar(Vehicle vehicle)
    {
        if (isPatrolling)
        {
            if (speedRadar != null)
            {
                speedRadar.TriggerRadar(vehicle);
                string measurement = speedRadar.GetLastReading();
                Console.WriteLine(WriteMessage($"Triggered radar. Result: {measurement}"));
            }
            else
            {
                Console.WriteLine(WriteMessage("has no active radar."));
            }
        }
        else
        {
            Console.WriteLine(WriteMessage($"Cannot use radar while not patrolling."));
        }
    }

        public bool IsPatrolling()
        {
            return isPatrolling;
        }

        public void StartPatrolling()
        {
            if (!isPatrolling)
            {
                isPatrolling = true;
                Console.WriteLine(WriteMessage("started patrolling."));
            }
            else
            {
                Console.WriteLine(WriteMessage("is already patrolling."));
            }
        }

        public void EndPatrolling()
        {
            if (isPatrolling)
            {
                isPatrolling = false;
                Console.WriteLine(WriteMessage("stopped patrolling."));
            }
            else
            {
                Console.WriteLine(WriteMessage("was not patrolling."));
            }
        }

        public void PrintRadarHistory()
        {
            if (speedRadar != null) 
            {
                Console.WriteLine(WriteMessage("Report radar speed history:"));
                foreach (float speed in speedRadar.SpeedHistory)
                {
                    Console.WriteLine(speed);
                }
            }
            else
            {
                Console.WriteLine(WriteMessage("No radar available to show history."));
            }
        }

        public void StartPersecuting(string vehiclePlate)
        {
            isPersecuting = true;
            Console.WriteLine($"Police car is now chasing vehicle: {vehiclePlate}");
        }
    }
}
namespace GarageBuilder.Vehicles
{
    class Airplane : Vehicle
    {
        // fields
        // ====================================================================
        private int numberOfEngines;
        private int passengerCapacity;
        // properties
        // ====================================================================
        public int NumberOfEngines
        {
            get {return numberOfEngines;}
            set {numberOfEngines = value;}
        }

        public int PassengerCapacity
        {
            get {return passengerCapacity;}
            set {passengerCapacity = value;}
        }
        // constructors
        // ====================================================================
        public Airplane(string id, string colour, int weight, int engines, int passengerCapacity) : base(id, colour, weight)
        {
            this.NumberOfEngines = engines;
            this.PassengerCapacity = passengerCapacity;
        }
        // methods
        // ====================================================================
    }
}
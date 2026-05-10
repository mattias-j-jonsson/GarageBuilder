namespace GarageBuilder.Vehicles
{
    class Bus : Vehicle
    {
        // fields
        // ====================================================================
        private bool electric;
        private int passengerCapacity;
        // properties
        // ====================================================================
        public bool Electric
        {
            get {return electric;}
            set {electric = value;}
        }
        public int PassengerCapacity
        {
            get {return passengerCapacity;}
            set {passengerCapacity = value;}
        }
        // constructors
        // ====================================================================
        public Bus(string id, string colour, int weight, bool electric, int passengerCapacity) : base(id, colour, weight)
        {
            this.Electric = electric;
            this.PassengerCapacity = passengerCapacity;
        }
        // methods
        // ====================================================================
    }
}
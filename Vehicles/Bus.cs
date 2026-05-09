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
        // methods
        // ====================================================================
    }
}
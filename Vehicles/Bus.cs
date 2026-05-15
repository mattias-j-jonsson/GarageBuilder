using System.Text;

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

        // text alignment helper properties
        public override int propertyLengthIndividualProp1 => Electric.ToString().Length + "Electric".Length;
        public override int propertyLengthIndividualProp2 => PassengerCapacity.ToString().Length + "Passenger capacity".Length;
        // constructors
        // ====================================================================
        public Bus(string id, string colour, int weight, bool electric, int passengerCapacity) : base(id, colour, weight)
        {
            this.Electric = electric;
            this.PassengerCapacity = passengerCapacity;
        }
        // methods
        // ====================================================================
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.ToString());
            sb.Append("Electric: ").Append(Electric).Append("    ");
            sb.Append("Passenger capacity: ").Append(PassengerCapacity);
            return sb.ToString();
        }
    }
}
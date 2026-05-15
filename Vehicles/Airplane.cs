using System.Text;

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

        // text alignment helper properties
        public override int propertyLengthIndividualProp1 => NumberOfEngines.ToString().Length + "Number of engines".Length;
        public override int propertyLengthIndividualProp2 => PassengerCapacity.ToString().Length + "Passenger capacity".Length;

        // constructors
        // ====================================================================
        public Airplane(string id, string colour, int weight, int engines, int passengerCapacity) : base(id, colour, weight)
        {
            this.NumberOfEngines = engines;
            this.PassengerCapacity = passengerCapacity;
        }
        // methods
        // ====================================================================
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.ToString());
            sb.Append("Number of engines: ").Append(NumberOfEngines).Append("    ");
            sb.Append("Passenger capacity: ").Append(PassengerCapacity);
            return sb.ToString();
        }
    }
}
using System.Text;

namespace GarageBuilder.Vehicles
{
    class Car : Vehicle
    {
        // fields
        // ====================================================================
        private bool fourWheelDrive;
        private bool electric;
        // properties
        // ====================================================================
        public bool FourWheelDrive
        {
            get {return fourWheelDrive;}
            private set {fourWheelDrive = value;}
        }

        public bool Electric
        {
            get {return electric;}
            set {electric = value;}
        }
        // constructors
        // ====================================================================
        public Car(string id, string colour, int weight, bool fourWheelDrive, bool electric) : base(id, colour, weight)
        {
            this.FourWheelDrive = fourWheelDrive;
            this.Electric = electric;
        }
        // methods
        // ====================================================================
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.ToString());
            sb.Append("Four wheel drive: ").Append(FourWheelDrive).Append("    ");
            sb.Append("Electric: ").Append(Electric);
            return sb.ToString();
        }
    }
}
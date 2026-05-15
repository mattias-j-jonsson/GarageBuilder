using System.Text;

namespace GarageBuilder.Vehicles
{
    class Boat : Vehicle
    {
        // fields
        // ====================================================================
        private Type boatType;
        // properties
        // ====================================================================
        public Type BoatType
        {
            get {return boatType;}
            set {boatType = value;}
        }

        // text alignment helper properties
        public override int propertyLengthIndividualProp1 => BoatType.ToString().Length + "Boat type".Length;
        // constructors
        // ====================================================================
        public Boat(string id, string colour, int weight, Type boatType) : base(id, colour, weight)
        {
            this.BoatType = boatType;
        }
        // methods
        // ====================================================================
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.ToString());
            sb.Append("Boat type: ").Append(BoatType);
            return sb.ToString();
        }
        // Types
        // ====================================================================
        public enum Type
        {
            outboarder,
            inboarder,
            sailboat
        }
    }
}
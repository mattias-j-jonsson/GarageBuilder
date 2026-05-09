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
        // constructors
        // ====================================================================
        // methods
        // ====================================================================
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
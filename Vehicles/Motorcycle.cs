namespace GarageBuilder.Vehicles
{
    class Motorcycle : Vehicle
    {
        // fields
        // ====================================================================
        private WeightClass weightclass;
        private int cylinderVolume;
        // properties
        // ====================================================================
        public WeightClass Weightclass
        {
            get {return weightclass;}
            set {weightclass = value;}
        }
        public int CylinderVolume
        {
            get {return cylinderVolume;}
            set {cylinderVolume = value;}
        }
        // constructors
        // ====================================================================
        public Motorcycle(string id, string colour, int weight, WeightClass weightclass, int cylinderVolume) : base(id, colour, weight)
        {
            this.Weightclass = weightclass;
            this.CylinderVolume = cylinderVolume;
        }
        // methods
        // ====================================================================
        // types
        // ====================================================================
        public enum WeightClass
        {
            lightweight,
            mediumweight,
            heavyweight
        }
    }
}
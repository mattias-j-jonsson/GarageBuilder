using System.Text;

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
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.ToString());
            sb.Append("Weight class: ").Append(Weightclass).Append("    ");
            sb.Append("Cylinder volume: ").Append(CylinderVolume);
            return sb.ToString();
        }
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
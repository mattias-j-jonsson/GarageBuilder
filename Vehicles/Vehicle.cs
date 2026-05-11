
using System;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GarageBuilder.Vehicles
{
    internal abstract class Vehicle
    {
        // fields
        // ====================================================================
        private string id;
        private string colour;
        private int weight;
        // int size; // optional functionality
        

        // properties
        // ====================================================================
        public string Id
        {
            get {return id;}
            private set {id = value;}
        }

        public string Colour
        {
            get {return colour;}
            private set
            {
                colour = value;
            }
        }
        public int Weight
        {
            get {return weight;}
            private set
            {
                if (value <= 0)
                {
                    // throw new ArgumentOutOfRangeException()
                }
                weight = value;
            }
        }

        // constructors
        // ====================================================================
        public Vehicle(string id, string colour, int weight)
        {
            this.Id = id;
            this.Colour = colour;
            this.Weight = weight;
        }
        // methods
        // ====================================================================
        public override string ToString()
        {
            string typeAsString = this.GetType().ToString().Split(".")[2];
            StringBuilder sb = new StringBuilder();
            sb.Append("Type: ").Append(typeAsString).Append("    ");
            sb.Append("ID: ").Append(Id).Append("    ");
            sb.Append("Colour: ").Append(Colour).Append("    ");
            sb.Append("Weight: ").Append(Weight).Append("    ");
            return sb.ToString();
        }
    }
}
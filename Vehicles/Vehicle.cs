
using System.ComponentModel.DataAnnotations;

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
            private set {weight = value;}
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
    }
}
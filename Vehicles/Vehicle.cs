
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
            private set
            {
                if(IsValidVehicleId(value))
                {
                    id = value;
                }
                else
                {
                    throw new ArgumentException("ID must be on form \"ABC123\"");
                }
                
            }
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
                    throw new ArgumentOutOfRangeException("Weight must be a positive integer");
                }
                weight = value;
            }
        }

        // constructors
        // ====================================================================
        public Vehicle(string id, string colour, int weight)
        {
            this.Id = id.ToUpper();
            this.Colour = colour.ToUpper();
            this.Weight = weight;
        }
        // methods
        // ====================================================================
        private bool IsValidVehicleId(string id)
        {
            Console.WriteLine("in validator. ID: " + id);
            bool correctLength = id.Length == 6;
            if (correctLength == false)
            {
                return false;
            }
            bool parseFirstHalfId = char.IsLetter(id[0]) && char.IsLetter(id[1]) && char.IsLetter(id[2]);
            bool parseSecondHalfId = int.TryParse(id.Substring(3, 3), out int throwAwayNumber);
            return parseFirstHalfId && parseSecondHalfId;
        }
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
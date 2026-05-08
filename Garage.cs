using System.Collections.Generic;
using System.Text.RegularExpressions;
using GarageBuilder.Vehicles;

namespace GarageBuilder
{
    internal class Garage
    {
        // fields
        // ====================================================================
        private Vehicle[] storageSpace = null;

        // constructors
        // ====================================================================
        public Garage(int capacity)
        {
            StorageSpace = new Vehicle[capacity];
        }
        // properties
        // ====================================================================
        public Vehicle[] StorageSpace
        {
            get {return storageSpace;}
            private set
            {
                storageSpace = value;
            }
        }
        // methods
        // ====================================================================
    }
}
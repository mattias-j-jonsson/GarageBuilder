using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using GarageBuilder.Vehicles;

namespace GarageBuilder
{
    internal class Garage
    {
        // fields
        // ====================================================================
        private Vehicle[] storageSpace = Array.Empty<Vehicle>();

        // properties
        // ====================================================================
        private Vehicle[] StorageSpace
        {
            get {return storageSpace;}
            set
            {
                storageSpace = value;
            }
        }
        // constructors
        // ====================================================================
        public Garage(int capacity)
        {
            StorageSpace = new Vehicle[capacity];
        }
        // methods
        // ====================================================================
    }
}
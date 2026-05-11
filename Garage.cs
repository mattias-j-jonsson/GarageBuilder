using System;
using System.Collections.Generic;
using System.Text;
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
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < StorageSpace.Length; i++)
            {
                sb.Append(StorageSpace[i]);
            }
            return sb.ToString();
        }
    }
}
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
        // private bool isFull;
        private int capacity;

        private int airplaneCount = 0;
        private int boatCount = 0;
        private int busCount = 0;
        private int carCount = 0;
        private int motorcycleCount = 0;

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
        public int Capacity
        {
            get {return capacity;}
            private set {capacity = value;}
        }

        public int VehicleCount
        {
            get {return airplaneCount + boatCount + busCount + carCount + motorcycleCount;}
        }

        public bool IsFull
        {
            get {return Capacity-VehicleCount <= 0;}
        }
        // constructors
        // ====================================================================
        public Garage(int capacity)
        {
            StorageSpace = new Vehicle[capacity];
            this.Capacity = capacity;
        }
        // methods
        // ====================================================================
        public void AddVehicle(Vehicle v)
        {
            if (VehicleCount < Capacity)
            {
                int index = 0;
                while (StorageSpace[index] != null)
                {
                    index++;
                }
                storageSpace[index] = v; // should copy rather than put input reference?
                if (v is Airplane)
                {
                    airplaneCount++;
                }
                else if (v is Boat)
                {
                    boatCount++;
                }
                else if (v is Bus)
                {
                    busCount++;
                }
                else if (v is Car)
                {
                    carCount++;
                }
                else if (v is Motorcycle)
                {
                    motorcycleCount++;
                }
            }
            else
            {
                Console.WriteLine("The garage has reached its limit. Please remove vehicles to free up space");
            }
        }

        public void RemoveVehicle(int index)
        {
            return;
        }


        public Vehicle? FindVehicle(string type = "", string id = "", string colour = "", int weight = 0)
        {
            foreach (Vehicle current in StorageSpace)
            {
                if(type != string.Empty && current.GetType().Name.ToUpper() != type.ToUpper())
                {
                    break;
                }
                else if (id != string.Empty && current.Id.ToUpper() != id.ToUpper())
                {
                    break;
                }
                else if (colour != string.Empty && current.Colour.ToUpper() != colour.ToUpper())
                {
                    break;
                }
                else if (weight != 0 && current.Weight != weight)
                {
                    break;
                }
                else
                {
                    return current;
                }
            }
            return null;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < StorageSpace.Length; i++)
            {
                if (StorageSpace[i] != null)
                {
                    sb.Append(StorageSpace[i]);
                    sb.Append('\n');
                }
            }
            sb.Remove(sb.Length-1, 1);
            return sb.ToString();
        }
    }


}
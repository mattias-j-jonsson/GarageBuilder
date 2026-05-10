using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Metadata;
using GarageBuilder.Vehicles;

namespace GarageBuilder
{
    internal static class MenuSystem
    {
        public static List<Vehicle> LoadVehiclesFromFile(string filePath)
        {
            string[] fileText = File.ReadAllLines(filePath);
            List<Vehicle> vehicleList = new List<Vehicle>(fileText.Length);

            foreach (string item in fileText)
            {
                string[] temp = item.Split(";");
                string id = temp[1].Substring(temp[1].IndexOf(":")+1).ToUpper();
                string colour = temp[2].Substring(temp[2].IndexOf(":")+1).ToUpper();
                bool parseSuccess = int.TryParse(temp[3].Substring(temp[3].IndexOf(":")+1), out int weight);
                switch (temp[0])
                {
                    case "Airplane":
                        parseSuccess = int.TryParse(temp[4].Substring(temp[4].IndexOf(":")+1), out int numberOfEngines);
                        parseSuccess = int.TryParse(temp[5].Substring(temp[5].IndexOf(":")+1), out int passengerCapacity);
                        vehicleList.Add(new Airplane(id, colour, weight, numberOfEngines, passengerCapacity));
                        break;
                    case "Boat":
                        parseSuccess = int.TryParse(temp[4].Substring(temp[4].IndexOf(":")+1), out int type);
                        vehicleList.Add(new Boat(id, colour, weight, (Boat.Type) type));
                        break;
                    case "Bus":
                        parseSuccess = bool.TryParse(temp[4].Substring(temp[4].IndexOf(":")+1), out bool electric);
                        parseSuccess = int.TryParse(temp[5].Substring(temp[5].IndexOf(":")+1), out passengerCapacity);
                        vehicleList.Add(new Bus(id, colour, weight, electric, passengerCapacity));
                        break;
                    case "Car":
                        parseSuccess = bool.TryParse(temp[4].Substring(temp[4].IndexOf(":")+1), out bool fourWheelDrive);
                        parseSuccess = bool.TryParse(temp[5].Substring(temp[5].IndexOf(":")+1), out electric);
                        vehicleList.Add(new Car(id, colour, weight, fourWheelDrive, electric));
                        break;
                    case "Motorcycle":
                        parseSuccess = int.TryParse(temp[4].Substring(temp[4].IndexOf(":")+1), out int weightclass);
                        parseSuccess = int.TryParse(temp[5].Substring(temp[5].IndexOf(":")+1), out int cylinderVolume);
                        vehicleList.Add(new Motorcycle(id, colour, weight, (Motorcycle.WeightClass) weightclass, cylinderVolume));
                        break;
                    default:
                        break;
                }
            }
            return vehicleList;
        }

        public static string DrawMenu(List<string> menuOptions)
        {
            string chosenOption = string.Empty;
            int menuIndex = 0;
            // Console.Clear();
            // Console.CursorVisible = false;

            while (chosenOption == string.Empty)
            {
                Console.Clear();
                for(int i = 0; i < menuOptions.Count; i++)
                {
                    if(i == menuIndex)
                    {
                        Console.BackgroundColor = ConsoleColor.DarkGreen;
                        Console.ForegroundColor = ConsoleColor.Black;
                    }
                    Console.WriteLine(menuOptions[i]);
                    Console.ResetColor();
                }

                ConsoleKeyInfo pressedKey = Console.ReadKey();

                switch (pressedKey.Key)
                {
                    case ConsoleKey.DownArrow:
                        if (menuIndex < menuOptions.Count-1)
                        {
                            menuIndex++;
                        }
                        break;
                    case ConsoleKey.UpArrow:
                        if (menuIndex > 0)
                        {
                            menuIndex--;
                        }
                        break;
                    case ConsoleKey.Enter:
                        chosenOption = menuOptions[menuIndex];
                        break;
                    default:
                        break;
                }
                // Console.Clear();

            }
            
            return chosenOption;
        }
    }
}
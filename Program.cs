using System;
using System.Collections.Generic;
using System.IO;
using GarageBuilder.Vehicles;

namespace GarageBuilder
{
    class Program
    {


        static void Main()
        {
            int size = MenuSystem.PrelimenaryMenu();
            Garage garage = new Garage(size);
            bool loadedQuestion = MenuSystem.LoadFileMenu();
            if (loadedQuestion)
            {
                string pathToFile = Environment.CurrentDirectory;
                pathToFile = pathToFile.Substring(pathToFile.IndexOf("GarageBuilder"));
                pathToFile = Path.GetRelativePath(pathToFile, "GarageBuilder/Data/vehicles.txt");
                List<Vehicle> fileInput = MenuSystem.LoadVehiclesFromFile(pathToFile);
                foreach (var item in fileInput)
                {
                    garage.AddVehicle(item);
                }
            }
            
            bool running = true;
            while(running)
            {
                string menuChoice = MenuSystem.MainMenu().Split(" ")[0];
                switch (menuChoice)
                {
                    case "Quit":
                        running = false;
                        break;
                    case "Print":
                        Console.WriteLine(garage.ToString());
                        Console.Read();
                        break;
                    case "Add":
                        if(garage.IsFull)
                        {
                            Console.WriteLine("The garage has reached its limit. Please remove vehicles to free up space");
                        }
                        else
                        {
                            Vehicle newVehicle = MenuSystem.GatherVehicleDetails();
                            garage.AddVehicle(newVehicle);
                        }
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
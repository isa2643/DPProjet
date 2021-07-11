using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternProjet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choissiez ce que vous voulez assembler comme vehicule :");
            Console.WriteLine("1- voiture");
            Console.WriteLine("2- camion");
            Console.WriteLine("3- moto");

            var choix = Console.ReadLine();


            switch (choix)
            {
                case "1":
                    var vehicleCreator = new VehicleCreator(new Voiture());
                    vehicleCreator.CreateVehicle();

                    break;
                case "2":
                    var vehicleCreator2 = new VehicleCreator(new Camion());
                    vehicleCreator2.CreateVehicle();

                    break;
                case "3":
                    var vehicleCreator3 = new VehicleCreator(new Moto());
                    vehicleCreator3.CreateVehicle();
                    break;

            }
        }
    }
}

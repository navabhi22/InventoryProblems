using System;

namespace InventoryDataManagementDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "C:/Users/Acer/source/repos/InventoryDataManagementDemo/Rice.json";

            FetcJsonForRice fetcJsonForRice = new FetcJsonForRice();

            Rice data = fetcJsonForRice.Read(path);
            Console.WriteLine("For Rice");
            Console.WriteLine("--------------------------");
            for (int i = 0; i < data.typesofRice.Count; i++)
            {
                Console.WriteLine("Name : " + data.typesofRice[i].name);
                Console.WriteLine("Price per Kg : " + data.typesofRice[i].Price);
                Console.WriteLine("Weight : " + data.typesofRice[i].weight);
                Console.WriteLine("Price : " + data.typesofRice[i].Price * data.typesofRice[i].weight);
                Console.WriteLine("--------------------------");
            }
            Console.WriteLine("For Pulses");
            Console.WriteLine("--------------------------"); ;
            for (int i = 0; i < data.typesofPulses.Count; i++)
            {
                Console.WriteLine("Name : " + data.typesofPulses[i].name);
                Console.WriteLine("Price per Kg : " + data.typesofPulses[i].Price);
                Console.WriteLine("Weight : " + data.typesofPulses[i].weight);
                Console.WriteLine("Price : " + data.typesofPulses[i].Price * data.typesofPulses[i].weight);
                Console.WriteLine("--------------------------");
            }
            Console.WriteLine("For Wheat");
            Console.WriteLine("--------------------------");
            for (int i = 0; i < data.typesofWheat.Count; i++)
            {
                Console.WriteLine("Name : " + data.typesofWheat[i].name);
                Console.WriteLine("Price per Kg : " + data.typesofWheat[i].Price);
                Console.WriteLine("Weight : " + data.typesofWheat[i].weight);
                Console.WriteLine("Price : " + data.typesofWheat[i].Price * data.typesofWheat[i].weight);
                Console.WriteLine("--------------------------");
            }

        }
    }
}
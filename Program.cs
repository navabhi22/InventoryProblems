using System;

namespace InventoryDataManagementDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "C:/Users/Acer/source/repos/InventoryDataManagementDemo/Inventory.json";
            InventoryManager inventoryManager = new InventoryManager();
            Products data = inventoryManager.Read(path);

            Console.WriteLine("For ProductType 1");
            Console.WriteLine("--------------------------");
            for (int i = 0; i < data.ProductType1.Count; i++)
            {
                Console.WriteLine("Name : " + data.ProductType1[i].Name);
                Console.WriteLine("Price per Kg : " + data.ProductType1[i].Price);
                Console.WriteLine("Weight : " + data.ProductType1[i].weight);
                Console.WriteLine("Total Price : " + data.ProductType1[i].Price * data.ProductType1[i].weight);
                Console.WriteLine("--------------------------");
            }
            Console.WriteLine("For Product Type 2");
            Console.WriteLine("--------------------------"); ;
            for (int i = 0; i < data.ProductType2.Count; i++)
            {
                Console.WriteLine("Name : " + data.ProductType2[i].Name);
                Console.WriteLine("Price: " + data.ProductType2[i].Price);
                Console.WriteLine("Qty : " + data.ProductType2[i].Qty);
                Console.WriteLine("TotalvPrice : " + data.ProductType2[i].Price * data.ProductType2[i].Qty);
                Console.WriteLine("--------------------------");
            }
            Console.WriteLine("For Product 3");
            Console.WriteLine("--------------------------");
            for (int i = 0; i < data.ProductType3.Count; i++)
            {
                Console.WriteLine("Name : " + data.ProductType3[i].Name);
                Console.WriteLine("Price : " + data.ProductType3[i].Price);
                Console.WriteLine("Liter : " + data.ProductType3[i].Liter);
                Console.WriteLine("Total Price : " + data.ProductType3[i].Price * data.ProductType3[i].Liter);
                Console.WriteLine("--------------------------");
            }

        }
    }
}
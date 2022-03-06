using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryDataManagementDemo
{
    public class Products
    {
        public List<Product1> ProductType1;
        public List<Product2> ProductType2;
        public List<Product3> ProductType3;
    }

    public class Product1
    {
        public string Name;
        public int weight;
        public int Price;
    }
    public class Product2
    {
        public string Name;
        public int Qty;
        public int Price;
    }
    public class Product3
    {
        public string Name;
        public int Liter;
        public int Price;
    }
}

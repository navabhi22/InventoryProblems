using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryDataManagementDemo
{
    public class Rice
    {
        public List<TypesOfRice> typesofRice;
        public List<TypesOfPulses> typesofPulses;
        public List<TypesOfWheat> typesofWheat;
    }

    public class TypesOfRice
    {
        public string name;
        public int weight;
        public int Price;
    }
    public class TypesOfPulses
    {
        public string name;
        public int weight;
        public int Price;
    }
    public class TypesOfWheat
    {
        public string name;
        public int weight;
        public int Price;
    }
}

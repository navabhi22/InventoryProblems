using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryDataManagementDemo
{
    public class StockManagement
    {
        public List<Stocks> StocksPortfolio;
    }

    public class Stocks
    {
        public string Name;
        public int Qty;
        public int Price;
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Buys
    {
        public List<string> storeName { get; set; }
        public List<string> supplierName { get; set; }
        public List<string> categoryName { get; set; }
        public List<Products> products { get; set; }
        public DateTime DateTime { get; set; }
        public double TotalPrice { get; set; }
        public Buys()
        {
            products = new List<Products>();
            supplierName = new List<string>();
            categoryName = new List<string>();
            storeName = new List<string>(); 
        }
    }
}

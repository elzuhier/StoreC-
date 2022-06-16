using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Sales
    {
        public List<string> storeName { get; set; }
        public List<string> distributerName { get; set; }
        public List<string> categoryName { get; set; }
        public List<Products> products { get; set; }
        public DateTime DateTime { get; set; }
        public double TotalPrice { get; set; }

        public Sales()
        {
            storeName = new List<string>();
            distributerName = new List<string>();
            categoryName = new List<string>();
            products = new List<Products>();
        }

    }
}

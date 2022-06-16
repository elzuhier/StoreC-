using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
     public class Store
    {
        public Store()
        {
           
        }
    
            public string storeName { get; set; }
    
        //
        public List<Category> categories= new List<Category>();

        //List<Suppliers> suppliers;
        //List<Customers> customers;
        //public Store (string Location)
        //{
        //    this.Location = Location;
        //    categories= new List<Category>();
        //    suppliers= new List<Suppliers>();
        //    customers= new List<Customers>();
        //}
    }
}

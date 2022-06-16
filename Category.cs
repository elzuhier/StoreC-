using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Category
    {
        
        
        public string CategoryName { get; set; }
        public string CategoryDescription{ get; set; }
        public int ID { get; set; }
        public List<Products> products=new List<Products>();

        public Category()
        {   
           ID =1 ;
        }
    }

}

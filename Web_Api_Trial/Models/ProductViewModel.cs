using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Data_Access_Layer_LinqToSql; 


namespace Web_Api_Trial.Models
{
    public class ProductViewModel
    {
        public List<Product> products;
        public int productCount;
    }
}
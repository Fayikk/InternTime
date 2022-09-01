using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Gun
{
    public class Product 
    {
        //Snippet

        public int Id { get; set; }//Bir nesneyi diğerlerinde ayırt edebilmek için kullandığımız bir alandır.
        public string ProductName { get; set; }
        public double UnitPrice { get; set; }
        public int CategoryId { get; set; }
        public int UnitsInStock { get; set; }

        //CRUD operations(create,read,update,delete) işlemleri
    }
}

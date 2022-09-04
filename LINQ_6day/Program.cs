using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Entity framework veritabanı işlerini yapabilmek için kullanılırlar.
//LINQ (Language ıntegrated query) Dile gömülü sorgulama anlamına gelmektedir.
namespace LINQ_6day
{
    
    public class Program
    {
        static void Main(string[] args)
        {   //Aşağıdaki yapılar sayesinde bir veri kaynağımız oldu.
            //İlerleyen zamanlarda bu yapılar bir tabanından,veri kaynağından vs gelebilir.
            List<Category> categories = new List<Category>
            {
                new Category{CategoryId=1,CategoryName="Bilgisyar"},
                new Category { CategoryId = 2, CategoryName = "Telefon" },  

            }; //Category class'ından liste türünden nesne oluşturalım.  
            List<Product> products = new List<Product>
            {
                new Product{productID=1,CategoryId=1,productName="Lenovo laptop",QuantityPerUnit="32 gb ram",UnitPrice=1000,UnitsInStock=10},
                new Product{productID=2,CategoryId=1,productName="asus laptop",QuantityPerUnit="12 gb ram",UnitPrice=4000,UnitsInStock=2},
                new Product{productID=3,CategoryId=2,productName="Apple",QuantityPerUnit="23 gb ram",UnitPrice=2000,UnitsInStock=3},
                new Product{productID=4,CategoryId=2,productName="samsung",QuantityPerUnit="122 gb ram",UnitPrice=12000,UnitsInStock=4},
                new Product{productID=5,CategoryId=2,productName="Huawei",QuantityPerUnit="34 gb ram",UnitPrice=4000,UnitsInStock=5},

            };
            //Ürünlerimin ismini ekrana yazdırmak istiyorum
            

            Console.WriteLine("-----------LINQ----------");
            var result = products.Where(p => p.UnitPrice > 3000 && p.UnitsInStock>3);

            foreach (var item in result)
            {
                Console.WriteLine(item.productName);
            }
            GetProducts(products);
        }
        //Eğer LINQ kullanmazsak yazmamız gereken kod aşağıdaki gibidir.
        static List<Product> GetProducts(List<Product> products)
        {
            List<Product> filteredProducts = new List<Product>();
            foreach (var product in products)
            {
                if (product.UnitPrice >= 3000 && product.UnitsInStock > 3)
                {
                    filteredProducts.Add(product);

                    //Console.WriteLine(product.productName);
                }

            }
            return filteredProducts;    
        }
        static List<Product> GetProductsLınq(List<Product> products)
        {
            return products.Where(p => p.UnitPrice > 3000 && p.UnitsInStock > 3).ToList();      
        }




    }
    class Product
    {
        public int productID { get; set; }
        public int CategoryId { get; set; }
        public string productName { get; set; }
        public string QuantityPerUnit { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitsInStock { get; set; }
    }
    class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}

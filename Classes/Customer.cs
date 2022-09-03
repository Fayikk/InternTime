using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Customer
    {   //Aşağıdaki yapı sayesinde bir field tanımlaması yaptık
        //Alan tanımlaması gerçekleştirdik.
        //public string FirstName;
        //Aşağıdaki tanımlamalar sayesinde properties tanımlamaları yaptık.
        public int Id { get; set; }
       
        private string _firstName;    
        public string FirstName { 
            get {
                return "Mr "+ _firstName;//Burada değer döndürme işlemini gerçekleştiriyoruz
            } 
            set { 
                _firstName = value;//private değer ataması yapıalan property'nin özelliklerinin değer atmasını yada değişimlerini
                //Set içerisinde gerçekleştiriyoruz.
            } }
        public string LastName { get; set; }
        public string City { get; set; }
    }
}

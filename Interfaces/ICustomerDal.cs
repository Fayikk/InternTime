using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface ICustomerDal
    {
        void Add();
        void Update();
        void Delete();
    }

    //Interfacelerin pratik olarak kullanım alanları görmüş oluyoruz bu sayede.
    //Birden fazla sql'e bağlanma işlemlerini gerçekleştiriyoruz ancak tek bir interface sayesinde 
    //Gerekli metodları ve yordamları override ediyoruz.
    class SqlServerCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Sql Added");
        }

        public void Delete()
        {
            Console.WriteLine("Sql Deleted");
        }

        public void Update()
        {
            Console.WriteLine("Sql Updated");
        }
    }
    class MongoDb : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Mongo Added");
            
        }

        public void Delete()
        {
            Console.WriteLine("Mongo Deleted");

        }

        public void Update()
        {
            Console.WriteLine("Mongo Updated");

        }
    }
    class OracleCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Oracle Added");
        }

        public void Delete()
        {
            Console.WriteLine("Oracle Deleted");
        }

        public void Update()
        {
            Console.WriteLine("Oracle updated");
        }





        
    }
    class CustomerManager
    {
        public void Add(ICustomerDal customerDal)
        {
            customerDal.Add();
        }

    }
}

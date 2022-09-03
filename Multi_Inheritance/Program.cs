using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multi_Inheritance
{//İşçiler,yöneticiler ve robotlar
    //Burada SOLIF prensiblerinde "I" geçerlidir anlamı ise Interface segregtion anlamına gelmektedir.
     public class Program
    {
        static void Main(string[] args)
        {
            IWorker[] workers = new IWorker[] {new Managers(),new Robots(),new Person()};
            foreach (var work in workers)
            {
                work.Work();
            }
            IEat[] eat = new IEat[] { new Person(), new Managers() };//Robotun nesnesini IEat interface'i ile oluşturamayız.
            ISalary[] salary= new ISalary[] {new Person(),new Managers() };
        }
    }
    interface IWorker
    {
        void Work();
        
    }
    interface ISalary
    {
        void GetSalary();
    }

    interface IEat
    {
        void GetEat();
    }

    class Managers : IWorker, ISalary, IEat
    {
        public void GetEat()
        {
            throw new NotImplementedException();
        }

        public void GetSalary()
        {
            throw new NotImplementedException();
        }

        public void Work()
        {
            Console.WriteLine("Çalışmalı");
        }
    }
    class Robots : IWorker
    {
        public void Work()
        {
            Console.WriteLine("Çalışmalı");

        }
    }
    class Person : IWorker,ISalary,IEat
    {
        public void GetEat()
        {
            throw new NotImplementedException();
        }

        public void GetSalary()
        {
            throw new NotImplementedException();
        }

        public void Work()
        {
            Console.WriteLine("Çalışmalı");

        }
    }
}


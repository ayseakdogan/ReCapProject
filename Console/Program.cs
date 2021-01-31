using Business.Concrete;
using DataAccess.Concrete.InMemory;
using DataAccess.Concrete.EntityFramework;
using System;

namespace Console
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryDal());


            CarManager carManager2 = new CarManager(new EntityFrameworkDal());


            foreach (var car in carManager.GetAll())
            {
                System.Console.WriteLine(car.Description);
            }

            foreach (var car in carManager2.GetAll())
            {
                System.Console.WriteLine(car.Description);
            }
        }
    }
}

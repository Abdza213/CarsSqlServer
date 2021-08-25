using Businuse.Concrete;
using DataAccess.Concrete;
using Entites.Concrete;
using System;

namespace ConsoleIU
{
    class Program
    {
        static void Main(string[] args)
        {

            CarManeger car = new CarManeger(new EfCarDal());

            foreach (var Item in car.GetCarDetails())
            {
                Console.WriteLine("{0} -- {1} -- {2}", Item.CarId, Item.BrandName, Item.DailyPrice);
            }
            Console.ReadKey();
        }
    }
}

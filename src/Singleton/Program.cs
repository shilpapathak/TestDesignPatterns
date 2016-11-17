using System;

namespace Singleton
{
    public class Program
    {
        public void Main(string[] args)
        {
            var goldLevelCustomers = Customer.GetInstance();
            var silverLevelCustomers = Customer.GetInstance();

            var customer1 = Customer.GetInstance();
            var customer2 = Customer.GetInstance();
            var customer3 = Customer.GetInstance();
            var customer4 = Customer.GetInstance();
            var customer5 = Customer.GetInstance();
            var customer6 = Customer.GetInstance();

            if (goldLevelCustomers == silverLevelCustomers)
            {
                Console.WriteLine("they both are same");
            }


            Console.ReadLine();
        }

    }
}

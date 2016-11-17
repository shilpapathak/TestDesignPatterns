using System;

namespace Singleton
{
    /// <summary>
    /// Customer class 
    /// </summary>
    class Customer
    {
        private static Customer _customer;
        protected Customer()
        {
            
        }

        public static Customer GetInstance()
        {
            //Lazy intialisation
            //Non thread safe 
            if (_customer == null)
            {
                _customer = new Customer();
                Console.WriteLine("customer object created.");
            }
            return _customer;
        }
    }
}

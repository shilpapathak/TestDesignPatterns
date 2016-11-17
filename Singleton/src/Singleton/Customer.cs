using System;

namespace Singleton
{
    /// <summary>
    /// Customer class 
    ///  The Singleton pattern simply uses a private constructor and
    ///  a static readonly instance variable that is lazily initialized. Thread safety is guaranteed by the compiler.
    /// </summary>
    class Customer
    {
        private static Customer _customer;
        private Customer()
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

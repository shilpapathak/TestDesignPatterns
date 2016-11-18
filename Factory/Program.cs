using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Factory
{
    public class Program
    {
        public void Main(string[] args)
        {
            Document[] document = new Document[2];

            document[0]= new Report();
            document[1] = new Resume();

            foreach (var doc in document)
            {
                Console.WriteLine("\n" +doc.GetType().Name);
                Console.WriteLine("----------------------");

                foreach (var page in doc.Pages)
                {
                    Console.WriteLine(page.GetType().Name);
                }
                
            }
            Console.Read();
        }
    }
}

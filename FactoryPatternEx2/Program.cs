using System;
using System.Collections.Generic;

namespace FactoryPatternEx2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the database you'd like to use:");
            Console.WriteLine("list, sql, mongo");

            var userInput = Console.ReadLine();

            IDataAccess db = DataAccessFactory.GetDataAccessType(userInput);

            var products = db.LoadData();
            db.SaveData();

            foreach (var product in products)
            {
                Console.WriteLine($"Name: {product.Name} - Price: {product.Price}");
            }

        }
    }
}


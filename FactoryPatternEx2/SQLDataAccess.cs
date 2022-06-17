using System;
using System.Collections.Generic;

namespace FactoryPatternEx2
{
	public class SQLDataAccess : IDataAccess
	{
        public static List<Product> Products = new List<Product>()
        {
            new Product (){Name = "laptop", Price = 500},
            new Product (){ Name = "phone", Price = 800},
            new Product (){ Name = "tv", Price = 1100},
        };


        public List<Product> LoadData()
        {
            Console.WriteLine("I am reading data from a SQL database.");
            return Products;
        }

        public void SaveData()
        {
            Console.WriteLine("I am saving data from a SQL database.");
        }
    }
}


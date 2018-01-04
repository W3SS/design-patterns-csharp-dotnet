using MoreLinq;
using SingletonPattern.Singleton.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace SingletonPattern.Singleton
{
    public class SingletonDatabase : IDatabase
    {
        private Dictionary<string, int> capitals;

        private static int instanceCount;

        public static int Count => instanceCount;

        private SingletonDatabase()
        {
            Console.WriteLine("Initializing database");

            try
            {
                capitals = File.ReadAllLines(
                  Path.Combine(
                    new FileInfo(typeof(IDatabase).Assembly.Location).DirectoryName, "capitals.txt")
                  )
                  .Batch(2)
                  .ToDictionary(
                    list => list.ElementAt(0).Trim(),
                    list => int.Parse(list.ElementAt(1)));
            }
            catch(Exception ex)
            {
                Console.WriteLine("Exception: ", ex.Message);
            }
        }

        public int GetPopulation(string name)
        {
            return capitals[name];
        }

        // laziness + thread safety
        private static Lazy<SingletonDatabase> instance = new Lazy<SingletonDatabase>(() =>
        {
            instanceCount++;
            return new SingletonDatabase();
        });

        public static IDatabase Instance => instance.Value;
    }
}

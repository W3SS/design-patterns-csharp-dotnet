using MoreLinq;
using System;
using System.Collections.Generic;

namespace AdapterPattern
{
    class Program
    {
        private static readonly List<NoCaching.VectorObject> vectorObjects = new List<NoCaching.VectorObject>
        {
          new NoCaching.VectorRectangle(1, 1, 10, 10),
          new NoCaching.VectorRectangle(3, 3, 6, 6)
        };

        // the interface we have
        public static void DrawPoint(NoCaching.Point p)
        {
            Console.Write(".");
        }
        
        private static void Draw()
        {
            foreach (var vo in vectorObjects)
            {
                foreach (var line in vo)
                {
                    var adapter = new NoCaching.LineToPointAdapter(line);
                    adapter.ForEach(DrawPoint);
                }
            }
        }

        private static readonly List<WithCaching.VectorObject> vectorObjectsWithCache = new List<WithCaching.VectorObject>
        {
          new WithCaching.VectorRectangle(1, 1, 10, 10),
          new WithCaching.VectorRectangle(3, 3, 6, 6)
        };

        // the interface we have
        public static void DrawPointWithCache(WithCaching.Point p)
        {
            Console.Write(".");
        }

        private static void DrawWithCache()
        {
            foreach (var vo in vectorObjectsWithCache)
            {
                foreach (var line in vo)
                {
                    var adapter = new WithCaching.LineToPointAdapter(line);
                    adapter.ForEach(DrawPointWithCache);
                }
            }
        }

        static void Main(string[] args)
        {
            // NO CACHING
            //Draw();
            //Draw();

            // WITH CACHING
            DrawWithCache();
            DrawWithCache();

            Console.ReadLine();
        }
    }
}

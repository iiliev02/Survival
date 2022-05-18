using System.Collections.Generic;

namespace Survival
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var animals = new List<Animal>();
            var engine = new Engine(animals);

            engine.Process();
        }
    }
}

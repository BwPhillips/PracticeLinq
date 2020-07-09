using System;
using System.Linq;
using System.Collections.Generic;


namespace PracticeLinqConsole
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string[] cars = { "Toyota", "Honda", "Mercedez", "Ford", "Ram", "Jeep" };

            var carNames = from car in cars
                           where car.Contains("o")
                           orderby car descending
                           select car;

            foreach (var car in carNames)
            {
                Console.WriteLine(car);
            }
            Console.WriteLine();

            List<string> videoGames = new List<string>
            { "Call of Duty", "Fortnite", "Mario", "Sonic", "Halo", "PubG" };

            IEnumerable<string> lengthOfGameName = videoGames.OrderByDescending(name => name.Contains(""));

            foreach (var index in videoGames)
            {

                Console.WriteLine(index);
            }
        }
    }
}

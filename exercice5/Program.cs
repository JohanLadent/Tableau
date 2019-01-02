using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercice5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            for (int number = 2; number < 7; number++)
            {
                numbers.Add(number);
            }
            numbers.Insert(0, 1); // Ajoute le 1 au début de la liste
            numbers.Add(7); // Ajoute la 7 à la suite de la liste 
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercice1
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] week = new String[] { "Lundi", "Mardi", "Mercredi", "Jeudi", "Vendredi", "Samedi", "Dimanche" };
            foreach (String Day in week)
            {
                Console.WriteLine(Day);
                // foreach = tableau de n'importe quel taille
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercice2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] week = new string[7];
            week[0] = "Lundi";
            week[1] = "Mardi";
            week[2] = "Mercredi";
            week[3] = "Jeudi";
            week[4] = "Vendredi";
            week[5] = "Samedi";
            week[6] = "Dimanche";
            Console.WriteLine(week[1]); // Affiche l'indice 1
            Console.WriteLine(week[4]); // Affiche l'indice 4

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exo3correction
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] week = new string[]
            {
                "Lundi", "Mardi", "Mercredi", "Jeudi", "Jeudi", "Samedi", "Dimanche"
            };
            int i = Array.IndexOf(week, "Jeudi"); // IndexOf permet de retrouver l'indice d'un elément dans un tableau, renvoie - 1 si l'elément n'existe pas
            week[i + 1] = "Vendredi";
            foreach (String day in week)
            {
                Console.WriteLine(day);
            }

            
        }
    }
}

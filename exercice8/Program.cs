using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercice8
{
    class Program
    {
        enum Week
        {
            Lundi,
            Mardi,
            Mercredi,
            Jeudi,
            Vendredi,
            Samedi,
            Dimanche
        }
        static void Main(string[] args)
        {
            string[] week = Enum.GetNames(typeof(Week));
            int i = Array.IndexOf(week, "Lundi");
            week[i] = "1"; // Remplace la valeur de lundi par un 1.
            foreach (String day in week)
            {
                Console.WriteLine(day);
            }
            Console.WriteLine(week[4]);
        }
    }
}

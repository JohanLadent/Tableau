using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercice7
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
            String[] week = Enum.GetNames(typeof(Week));
            foreach (String day in week)
            {
                Console.WriteLine(day);
            }

            Console.WriteLine(week[4]); // Affiche la valeur 4 de l'énumération = Vendredi.
        }
    }
}

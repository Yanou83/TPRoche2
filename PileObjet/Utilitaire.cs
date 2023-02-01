using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilitaires
{
    public abstract class Utilitaire
    {
        /// Demande la saisie d'un nombre entier
        /// Retourne ce nombre
        /// <summary>
        /// </summary>
        /// <returns></returns>
        public static int SaisirNb()
        {
               Console.Write("Veuillez saisir une valeur : ");
               int nb = Convert.ToInt32(Console.ReadLine());
                return nb;
               
        }


        /// Demande saisie d'un nombre entier ayant pour valeur min pMin
        public static int SaisirNb(int pMin)
        {
            int nb = 0;
            do{
             try
                {
                Console.Write("Veuillez saisir un nombre entier supérieur à " + pMin + " : ");
                 nb = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException){ }
                } while (nb<pMin);
            return nb;
            }
            

        /// Demande saisie d'un nombre entier compris entre pMin et pMax
        public static int SaisirNb(int pMin, int pMax)
        {
            int nb = 0;
            do{
             try
                {
                Console.Write($"Veuillez saisir un nombre entier supérieur à  {pMin} et inférieur à {pMax} : ");
                 nb = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException){ }
                } while (nb<pMin && nb>pMax);
            return nb;
            }
        }


    }
}

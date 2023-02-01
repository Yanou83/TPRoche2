using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PileObjet
{
    class Program
    {
        static void Main(string[] args)
        {
            //TestePileVidePleine(5);
            //TestePileVidePleine(0);
            //TesteEmpiler(5);
            //TesteEmpiler(2);
            //TesteEmpilerDepiler(5);
            int nbSaisi = Utilitaires.Utilitaire.SaisirNb();
            Console.WriteLine("Nombre saisi : " + nbSaisi);
            nbSaisi = Utilitaires.Utilitaire.SaisirNb(10);
            Console.WriteLine("Nombre saisi : " + nbSaisi);
            nbSaisi = Utilitaires.Utilitaire.SaisirNb(10, 30);
            Console.WriteLine("Nombre saisi : " + nbSaisi);

            Console.WriteLine("Fin du programme");
            Console.ReadKey();
        }

        public static void TestePileVidePleine(int nbElements)
        {
            Pile unePile = new Pile(nbElements);
            if (unePile.PileVide())
            {
                Console.WriteLine("La pile est vide");
            }
            else
            {
                Console.WriteLine("La pile n'est pas vide");
            }
            if (unePile.PilePleine())
            {
                Console.WriteLine("La pile est pleine");
            }
            else
            {
                Console.WriteLine("La pile n'est pas pleine");
            }
        }

        public static void TesteEmpiler(int nbElements)
        {
            Pile unePile = new Pile(nbElements);
            unePile.Empiler(2);
            unePile.Empiler(14);
            unePile.Empiler(6);
        }

        public static void TesteEmpilerDepiler(int nbElements)
        {
            try
            {
                Pile unePile = new Pile(nbElements);
                unePile.Empiler(2);
                unePile.Empiler(22);
                int valeurDepilee = (int)unePile.Depiler();
                Console.WriteLine("valeur dépilée : " + valeurDepilee);
                unePile.Empiler(17);
                while (!unePile.PileVide())
                {
                    valeurDepilee = (int)unePile.Depiler();
                }
                unePile.Depiler();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }

    
}

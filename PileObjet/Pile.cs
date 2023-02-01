using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PileObjet
{
    class Pile
    {
        /// <summary>
        /// Nombre maximum d'éléments de la Pile
        /// </summary>
        private int nbMaxElt;



        /// <summary>
        /// Liste contenant les éléments de la pile
        /// </summary>
        private System.Collections.Generic.List<int> elements;




        /// <summary>
        /// Constructeur PILE
        /// </summary>
        /// <param name="nbMaxElt"></param>
        public Pile(int nbMaxElt)
        {
            this.nbMaxElt = nbMaxElt;
            this.elements = new System.Collections.Generic.List<int>();
        }

        public bool PileVide()
        {
            return (this.elements.Count - 1 == 0);
        }



        /// <summary>
        /// retourne un booléen indiquant si la pile est pleine
        /// Une pile est pleine si son nombre d'élément vaut le maximum
        /// </summary>
        /// <param name="pUnePile"></param>
        /// <returns></returns>

        public bool PilePleine()
        {
            return (this.elements.Count == this.nbMaxElt);
        }
        
        /// <summary>
        /// Ajoute un élément à la liste si la pile n'est pas pleine
        /// Déclenche une exception si la pile est pleine
        /// </summary>
        /// <param name="nb"></param>

        public void Empiler(int nb)
        { 
            if (!PilePleine())
            {
                this.elements.Add(nb);
            }
            else
            {
                throw new Exception("Impossible d'emplier, la pile est pleine !");
            }

        }

        /// <summary>
        /// Dépile un élément tant que la pile n'est pas vide
        /// Sinon déclenche une exception
        /// </summary>
        /// <returns></returns>

        public int Depiler()
        {

            if (this.PileVide())
            {
                throw new Exception("Pile vide, impossible de continuer de dépiler");
            }
            else
            {
                int a = (int)this.elements[this.elements.Count - 1];
                this.elements.RemoveAt(this.elements.Count - 1);
                return a;
            }
        }

    }
}

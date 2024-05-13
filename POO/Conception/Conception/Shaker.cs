using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Conception
{
    public class Shaker
    {
        double _contenanceMax;
        List<Portion> _contenu;
        bool _propre;

        // CONSTRUCTEUR
        public Shaker(double contenanceMax, bool propre)
        {
            _contenanceMax = contenanceMax;
            _propre = propre;
            _contenu = new List<Portion>();
        }

        bool Propre { get { return _propre; } set { _propre = value; } }

        // Permet d'avoir la contenance Max
        public double ContenanceMax
        {
            get { return _contenanceMax; }
        }  

        // Calcul la quantite du contenu
        public double CalculQuantiteContenu()
        {
            double quantite = 0;
            foreach (Portion contenu in _contenu)
            {
                quantite = quantite + contenu.Quantite*0.2;
            }
            return quantite;
        }

        // Ajouter la quantité de liquide de la portion dans le shaker
        internal void AjouterPortion(Portion portion)
        {
            _contenu.Add(portion);
            _propre = false;
        }
    }
}

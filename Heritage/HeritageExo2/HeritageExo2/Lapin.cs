using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace HeritageExo2
{
    class Lapin:Animal
    {
        protected decimal _tailleOreille;

        public decimal TailleOreille
        {
            get { return _tailleOreille; }
        }
        bool Sauter(bool type)
        {
            return type;
        }

        public Lapin(decimal tailleOreille, string nom, string dateDeNaissance, decimal numeroPuce, bool concours) : base(nom, dateDeNaissance, numeroPuce, concours)
        {
            _tailleOreille = tailleOreille;
        }

        public override string Affiche()
        {
            return "Le Lapin " + Nom + " a pour date de naissance : " + DateDeNaissance + ", comme numéeo de puce " + NumeroPuce + ", participe au concours : " + Concours + ", à comme taille d'oreille : " + TailleOreille + ", saute : " + saut + ".";
        }
    }
}

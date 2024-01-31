using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeritageExo2
{
    class Chien : Animal
    {
        bool Aboyer(bool type)
        {
            return type;
        }

        public Chien(string nom, string dateDeNaissance, decimal numeroPuce, bool concours) : base(nom, dateDeNaissance, numeroPuce, concours)
        {
        }

        public override string Affiche()
        {
            return "Le Chien " + Nom + " a pour date de naissance : " + DateDeNaissance + ", comme numéeo de puce " + NumeroPuce + ", participe au concours : " + Concours + ", aboyer : " + Aboyer(true);
        }
    }
}

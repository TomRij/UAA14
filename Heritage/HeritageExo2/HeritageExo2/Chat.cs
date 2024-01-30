using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeritageExo2
{
    class Chat : Animal
    {
        bool Miauler(bool type)
        {
            return type;
        }

        bool Ronronner(bool type)
        {
            return type;
        }
        public Chat(string nom, string dateDeNaissance, decimal numeroPuce, bool concours) : base(nom, dateDeNaissance, numeroPuce, concours)
        {
            
        }

        public override string Affiche()
        {
            return "Le Chat " + Nom + " a pour date de naissance : " + DateDeNaissance + ", comme numéeo de puce " + NumeroPuce + ", miaule : " + Miauler(true) + ", ronronne : " + Ronronner(false);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeritageExo2
{
    class Animal
    {
        protected string _nom;
        protected string _dateDeNaissance;
        protected decimal _numeroPuce;
        protected bool _concours;

        public string Nom
        {
            get
            {
                return _nom;
            }
            set 
            {
                _nom = value;
            }
        }
        public string DateDeNaissance
        {
            get
            {
                return _dateDeNaissance;
            }
        }
        public decimal NumeroPuce
        {
            get
            {
                return _numeroPuce;
            }
        }
        public bool Concours
        {
            get
            {
                return _concours;
            }
            set
            {
                _concours = value;
            }
        }

        public Animal(string nom, string dateDeNaissance, decimal numeroPuce, bool concours)
        {
            _nom = nom;
            _dateDeNaissance = dateDeNaissance;
            _numeroPuce = numeroPuce;
            _concours = concours;
        }

        public virtual string Affiche()
        {
            return "L'hêtre " + Nom + " a pour est né le : " + DateDeNaissance + ", son numéeo de puce est le " + NumeroPuce + " et participe " + Concours+".";
        }

    }
}

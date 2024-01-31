using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeritageExo4
{
    internal abstract class Employe
    {
        protected string Matricule;
        protected string Nom;
        protected string Prenom;
        protected DateTime DateNaissance;

        public Employe(string matricule, string nom, string prenom, DateTime dateNaissance)
        {
            Matricule = matricule;
            Nom = nom;
            Prenom = prenom;
            DateNaissance = dateNaissance;
        }

        public abstract string Afficher();
    }
}


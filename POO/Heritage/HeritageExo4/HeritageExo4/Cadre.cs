using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeritageExo4
{
    internal class Cadre : Employe
    {
        private int Indice;
        private double Salaire;

        public Cadre(string matricule, string nom, string prenom, DateTime dateNaissance, int indice)
            : base(matricule, nom, prenom, dateNaissance)
        {
            Indice = indice;
            switch (indice)
            {
                case 1:
                    Salaire = 13000;
                    break;
                case 2:
                    Salaire = 15000;
                    break;
                case 3:
                    Salaire = 17000;
                    break;
                case 4:
                    Salaire = 20000;
                    break;
                default:
                    Salaire = 0;
                    break;
            }
        }

        public override string Afficher()
        {
            return $"Cadre - Matricule: {Matricule}, Nom: {Nom}, Prénom: {Prenom}, Date de Naissance: {DateNaissance.ToShortDateString()}, Indice: {Indice}, Salaire: {Salaire} écus";
        }
    }
}

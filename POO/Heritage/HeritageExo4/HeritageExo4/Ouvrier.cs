using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeritageExo4
{
    internal class Ouvrier : Employe
    {
        private DateTime DateEntreeSociete;
        private double Salaire;

        public Ouvrier(string matricule, string nom, string prenom, DateTime dateNaissance, DateTime dateEntreeSociete, int anciennete)
            : base(matricule, nom, prenom, dateNaissance)
        {
            DateEntreeSociete = dateEntreeSociete;
            Salaire = 2500 + Math.Min(100 * anciennete, 2 * 2500);
        }

        public override string Afficher()
        {
            return $"Ouvrier - Matricule: {Matricule}, Nom: {Nom}, Prénom: {Prenom}, Date de Naissance: {DateNaissance.ToShortDateString()}, Date d'Entrée: {DateEntreeSociete.ToShortDateString()}, Salaire: {Salaire} écus";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeritageExo4
{
    internal class Directeur : Employe
    {
        private double ChiffreAffaires;
        private double Pourcentage;
        private double Salaire;

        public Directeur(string matricule, string nom, string prenom, DateTime dateNaissance, double chiffreAffaires, double pourcentage)
            : base(matricule, nom, prenom, dateNaissance)
        {
            ChiffreAffaires = chiffreAffaires;
            Pourcentage = pourcentage;
            Salaire = ChiffreAffaires * Pourcentage;
        }

        public override string Afficher()
        {
            return $"Directeur - Matricule: {Matricule}, Nom: {Nom}, Prénom: {Prenom}, Date de Naissance: {DateNaissance.ToShortDateString()}, Chiffre d'Affaires: {ChiffreAffaires} écus, Pourcentage: {Pourcentage * 100}%, Salaire Annuel: {Salaire} écus";
        }
    }
}

using System;

namespace ACT_2_POO_exercices_simples
{
    class Personne
    {
        private string _nom;
        private double _porteMonnaie;

        public Personne(string nom, double porteMonnaie)
        {
            _nom = nom;
            _porteMonnaie = porteMonnaie;
        }

        public double PorteMonnaie
        {
            get { return _porteMonnaie; }
        }

        public void RecevoirArgent(double montant)
        {
            if (montant > 0)
                _porteMonnaie += montant;
        }

        public bool DonnerArgent(Personne autrePersonne, double montant)
        {
            if (montant > 0 && _porteMonnaie >= montant)
            {
                _porteMonnaie -= montant;
                autrePersonne.RecevoirArgent(montant);
                return true;
            }
            return false;
        }
    }
}

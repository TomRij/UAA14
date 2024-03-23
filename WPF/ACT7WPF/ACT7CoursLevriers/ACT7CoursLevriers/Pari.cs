using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace ACT7CoursLevriers
{
    class Pari
    {
        private int _montant = 0;
        int _numChien = 0;
        Parieur _joueur;

        public int Montant
        {
            get { return _montant; }
            set { _montant = value; }
        }
            public int NumChien
        {
            get { return _numChien; }
            set { _numChien = value; } 
        }
        public Parieur Joueur
        {
            get { return _joueur; }
            set { _joueur = value; }
        }
        public Pari(int montant,  int numChien)
        {
            _montant = montant;
            _numChien = numChien;
        }

        public void GetDescription(TextBlock txtInfosBlock, string txtInfosString)
        {
            string chaine = "";
            if (_montant != 0)
            {
                chaine = $"{_joueur.Nom} a parié {_montant} sur le chien #{_numChien + 1}";
            }
            else
            {
                chaine = $"{_joueur.Nom} n'a pas encore parié ";
            }
            txtInfosBlock.Text = chaine;
        }

        public int PrixFinal(int numGagnant)
        {
            int prix = 0;
            if (_numChien == numGagnant)
            {
                prix = 2 * _montant;
            }
            return prix;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I2P623_RijckaertTom
{
    class FeuDeSignalisation
    {
        private int _couleur;
        private string _identifiant;

        public FeuDeSignalisation(int couleur, string identifiant)
        {
            _couleur = couleur;
            _identifiant = identifiant;
        }

        int Change(int couleur, string identifiant)
        {
            string etat_couleur = "";
            for (int i = 0; i < 5; i++)
            {
                if (couleur == 0)
                {
                    return couleur = 1;

                }
                else if (couleur == 1)
                {

                    return couleur = 0;
                }
            }
        }
        public int GetCouleur()
        {
        }

        public void Clignote(ref int couleur, string identifiant);
        {
            string etat_cligno = "";
                for (int i = 0; i< 5; i++)
                {
                    if (_couleur == 0)
                    {
                        _couleur = 1;
                        return etat_cligno = "allumé";
                    }
                    else
                    {
                        _couleur = 0;
                        return etat_cligno = "étaint";
                    }
                }

        }

        string AfficheEtat(etat_couleur)
        {
            for (int i = 0; i < 5; i++)
            {

            }
        }


    }
    
}

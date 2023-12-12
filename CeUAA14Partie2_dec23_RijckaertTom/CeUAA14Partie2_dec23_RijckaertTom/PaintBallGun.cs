using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CeUAA14Partie2_dec23_RijckaertTom
{
    class PaintBallGun
    {
        private int _nbreBalles;
        private int _chargeur;

        public PaintBallGun(int nbreBalles, int chargeur)
        {
            _chargeur = chargeur;
            _nbreBalles = nbreBalles;
        }

        public int nbreBalles
        {
            get { return _nbreBalles; }
            set { _nbreBalles = value; }
        }
        public int chargeur
        {
            get { return _chargeur; }
            set { _chargeur = value; }
        }
        // quand le joueur tir cela fait en sorte qu'il perd une balle dans son chargeur
        public int Tirer()
        {
            return _chargeur--;
        }
        // cela permet au joueur de recharger les balles de en poches sont transmises au chargeur
        public int Recharger()
        {
            int a = 0;
            _chargeur = a;
            _nbreBalles -= a;
            _nbreBalles -= 16;
            _chargeur += 16;

            return _chargeur & _nbreBalles;
        }
        // cela indique l'état des munitions dans la poche du joueur (combien il en reste)
        public string Vide()
        {
            if (_nbreBalles == 0)
            {
                return "Vous n'avez plus de munitions !";
            }
            if(_nbreBalles < 0){
                return "Vous êtes endètées WARNING !";
            }
            else
            {
                return "Il vous reste des munitions dans votre poche";
            }
        }
        // cela permet de rajouter des balles dans la poche du joueur
        public int PrendreMunitions()
        {
            return _nbreBalles += 30;
        }
        // cela permet d'indiquer l'état du chargeur de joueur
        public string ChargeurRecharger()
            {
            if (_chargeur == 0)
            {
                return "Votre arme n'a plus de munitions ! (il faut recharger)";
            }
            if (_chargeur < 0)
            {
                return "Vous ne pouvez pas tirer à blanc attention votre arme va finir par casser si vous continué !";
            }
            else                
            {
                    return "Votre chargeur n'est pas vide";
                }
            }

            
        }
    }


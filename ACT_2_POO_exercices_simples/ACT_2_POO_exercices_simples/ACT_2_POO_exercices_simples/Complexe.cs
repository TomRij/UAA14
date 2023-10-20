using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACT_2_POO_exercices_simples
{
    class Complexe
    {
        private int _reelle;
        private int _imaginaire;

        public Complexe(int reelle, int imaginaire)
        {
            _reelle = reelle;
            _imaginaire = imaginaire;
        }

        public string AfficheComplexe()
        {
            return $"({_reelle}, {_imaginaire}";
        }

        public int CalculeModule()
        {
            return _reelle * _reelle + _imaginaire * _imaginaire;
        }

        public void Ajoute(Complexe x)
        {

        }
    }
}

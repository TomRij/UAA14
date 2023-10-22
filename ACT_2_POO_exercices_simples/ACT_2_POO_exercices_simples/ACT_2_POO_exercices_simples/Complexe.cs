using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACT_2_POO_exercices_simples
{
    class Complexe
    {
        private double _reelle;
        private double _imaginaire;

        public Complexe(double reelle, double imaginaire)
        {
            _reelle = reelle;
            _imaginaire = imaginaire;
        }

        public double Reelle
        {
            get { return _reelle; }
            set { _reelle = value; }
        }

        public double Imaginaire
        {
            get { return _imaginaire; }
            set { _imaginaire = value; }
        }

        public string AfficheComplexe()
        {
            return $"({_reelle}, {_imaginaire})";
        }

        public double CalculeModule()
        {
            return Math.Sqrt(_reelle * _reelle + _imaginaire * _imaginaire);
        }

        public void Ajoute(Complexe x)
        {
            _reelle += x.Reelle;
            _imaginaire += x.Imaginaire;
        }
    }
}
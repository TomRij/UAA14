using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicules
{
    class Voiture:Vehicule
    {
        protected string _motorisation;
        protected bool _gps;

        public string Motorisation { get { return _motorisation; } }
        public bool Gps { get { return _gps; } }

        public Voiture(string motorisation, bool gps, string modele, string marque, string couleur, decimal prix) : base(modele, marque, couleur, prix)
        {
            _motorisation = motorisation;
            _gps = gps;
        }
        
        public override string Affiche()
        {
            return "Le vehucule " + Modele + " a pour marque : " + Marque + ", comme couleur " + Couleur + " et comme prix : " + Prix+" possède commme mototisation : "+Motorisation+", GPS : "+Gps+".";
        }
        
        

    }
}

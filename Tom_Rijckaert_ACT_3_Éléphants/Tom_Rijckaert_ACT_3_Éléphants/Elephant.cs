using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tom_Rijckaert_ACT_3_Éléphants
{
    class Elephant
    {
        private string _nom;
        private uint _TailleOreilles;

        public Elephant(string nom, uint tailleOreilles)
        {
            _nom = nom;
            _TailleOreilles = tailleOreilles;
        }
        public string Nom
        {
            get { return _nom; }
        }
        public uint TailleOreilles
        {
            get { return _TailleOreilles; }
        }
        public string Affichequijesuis()
        {
            return _nom + " a une taille d'oreille de " + _TailleOreilles;
        }

        public void EcouteMessage(string message, Elephant quiDit)
        {
            Console.WriteLine(_nom + " a entendu un message \n" + quiDit._nom + " a dit : " + message);

        }
        public void EnvoieMessage(string message, Elephant quiRecoit)
        {
            quiRecoit.EcouteMessage(message, this);
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TomRijckaertExoChien
{
    class Chien
    {
        private string _nom;
        private string _race;
        private uint _age;
        private bool _vacciner;
        private bool _puce;
        private string _genre;
        private bool _sterilise;
        private bool _dresse;

        public Chien(string nom, string race, uint age, bool vacciner, bool puce, string genre, bool sterilise, bool dresse)
        {
            _nom = nom;
            _race = race;
            _age = age;
            _vacciner = vacciner;
            _puce = puce;
            _genre = genre;
            _sterilise = sterilise;
            _dresse = dresse;
        }

        // Une méthode pour formater les attributs d'un chien dans une string 
        public string AfficherCaractéristiques()
        {
            string chaine = "Nom : " + _nom + "Race : " + _race + " - Age : " + _age + "Vacciner : " + _puce + "Genre : " + "Sterilise : " + _sterilise + "Dresse " + _dresse;

            return chaine;
        }

    }
}

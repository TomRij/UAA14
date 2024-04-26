using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conception
{
    class Cocktail
    {
        private string _nom;
        private double _contenance;
        private Recette _recetteCocktail;

        public string Nom { get { return _nom; } }
        public double Contenance { get { return _contenance; } set { _contenance = value; } }
        public Recette RecetteCocktail { get {  return _recetteCocktail; } }

        public Recette Recette { get; }

        public Cocktail(string _nom, double _contenance, Recette RecetteCocktail)
        {
            _nom = Nom;
            _contenance = Contenance;
            _recetteCocktail = RecetteCocktail;
        }

        public Cocktail(Recette recette)
        {
            Recette = recette;
        }

        //public Cocktail CreerCocktail()
        //{

        //}
    }
}

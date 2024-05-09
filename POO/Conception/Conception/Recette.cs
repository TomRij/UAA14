using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conception
{
    class Recette
    {
		private Portion[] _ingredients;
		private string _nomRecettes;

		public Recette(Portion[] ingredients, string nomRecettes)
		{
			_ingredients = ingredients;
			_nomRecettes = nomRecettes;
		}

		public string NomRecettes
		{
			get { return _nomRecettes; }
			set { _nomRecettes = value;}
		}

		public Portion[] Ingredients
		{
			get { return _ingredients; }
			set { _ingredients = value; }
		}

        public int Length { get; internal set; }
    }
}

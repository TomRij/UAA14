using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACT_2_POO_exercices_simples
{
    class SandwichMaker
    {
        private string[] proteines = { "jambon", "fromage", "poulet", "thon" };
        private string[] condiments = { "mayo", "brazil", "ketchup", "sauce barbecue" };
        private string[] pain = { "blanc", "complet", "baguette", "sandwich mou" };
        private string[] crudités = { "salade", "tomate", "carotte", "cornichon" };

        public string ComposeSandwich()
        {
            Random random = new Random();

            string proteineAleatoire = proteines[random.Next(proteines.Length)];
            string condimentAleatoire = condiments[random.Next(condiments.Length)];
            string painAleatoire = pain[random.Next(pain.Length)];
            string cruditeAleatoire = crudités[random.Next(crudités.Length)];

            return $"Sandwich : {proteineAleatoire}, {condimentAleatoire}, {painAleatoire}, {cruditeAleatoire}";
        }
    }
}

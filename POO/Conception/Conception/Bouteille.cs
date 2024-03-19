using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conception
{
   public class Bouteille
    {
        private Liquide _contenu;
        private double _contenance;

        public Liquide Contenu
        {
            get 
            { 
                return _contenu;
            }
            set
            {
                _contenu = value;
            }
        }
        public double Contenance { 
            get 
            { 
                return _contenance;
            }
            set
            {
                _contenance = value;
            }
         }

        public bool Verser(Portion portion)
        {

        }
        public bool Jeter()
        {

        }

    }
}

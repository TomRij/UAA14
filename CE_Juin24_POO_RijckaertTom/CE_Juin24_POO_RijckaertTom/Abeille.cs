using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CE_Juin24_POO_RijckaertTom
{
    public class Abeille
    {
        private string _role;
        private double _energiePartQuart;

        public string Role
        {
            get { return _role; }
            set { _role = value; }
        }

        public double EnergiePartQuart
        {
            get { return _energiePartQuart; }
            set { _energiePartQuart = value; }
        }

        public bool EffectuerLeProchainQuart()
        {
            bool ok = false;

            if (Ruche.ConsommeMiel(_energiePartQuart))
            {
                FaitLeJob();
                ok = true;
            }
            return ok;
        }
        public abstract void FaitLeJob();
    }

}

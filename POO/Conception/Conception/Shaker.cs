using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conception
{
    class Shaker
    {
        double _contenanceMax;
        Portion[] _contenu;
        bool _propre;

        public Shaker(double contenanceMax, bool propre)
        {
            _contenanceMax = contenanceMax;
            _propre = propre;
        }

        double ContenanceMax
        {
            get { return _contenanceMax; }
        }
        Portion[] Contenu { get { return _contenu; } set { _contenu = value; } }
        bool Propre { get { return _propre; } set { _propre = value; } }

        public bool AjouterPortion (Portion portion)
        {

        }
        public Cocktail MelangeContenu()
        {

        }
        static void Vider()
        {

        }
        public bool Laver()
        {

        }
    }
}

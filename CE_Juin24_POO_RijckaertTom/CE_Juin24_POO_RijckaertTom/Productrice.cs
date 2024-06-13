using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CE_Juin24_POO_RijckaertTom
{
    class Productrice : Abeille
    {
        const double QTE_MAX_MIEL_PRODUIT_PAR_QUART = 33.15d;
        const double TAUX_CONVERSION_NECTAR_EN_MIEL = 0.19d;

        public Productrice()
        {
            Role = "Productrice de Miel";
            EnergiePartQuart = Ruche.MIEL_CONSOMME_PAR_PRODUCTRICES;
        }

        public double TransformeNectarEnMiel()
        {
            Random alea = new Random();
            double quantiteNectarTransforme;

            quantiteNectarTransforme = alea.NextDouble()*Ruche.quantiteNectar;
            if (quantiteNectarTransforme > QTE_MAX_MIEL_PRODUIT_PAR_QUART / TAUX_CONVERSION_NECTAR_EN_MIEL)
            {
                quantiteNectarTransforme = QTE_MAX_MIEL_PRODUIT_PAR_QUART / TAUX_CONVERSION_NECTAR_EN_MIEL;
            }
            return quantiteNectarTransforme;
        }

        public override void FaitLeJob()
        {
            double qteNectarTransforme;
            qteNectarTransforme = TransformeNectarEnMiel();
            if (qteNectarTransforme > 0)
            {
                Ruche.quantiteNectar -= qteNectarTransforme;
                Ruche.quantiteMiel += qteNectarTransforme * TAUX_CONVERSION_NECTAR_EN_MIEL;
            }
            else
            {
                Ruche.alerteManqueNectar = "Plus de Nectar ! envoyez des collectrices !";
            }
        }

    }

    
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CE_Juin24_POO_RijckaertTom
{
    class Reine : Abeille
    {
        const double NB_OUEUFS_PONDUS_PAR_QUART = 0.45d;
        private string _rapportEtatRuche = "";

        public string RapportEtatRuche
        {
            get { return _rapportEtatRuche; }
            set { _rapportEtatRuche = value; }
        }

        public Reine()
        {
            Role = "Reine";
            EnergiePartQuart = Ruche.MIEL_CONSOMME_PAR_REINE;
        }

        public bool AjouteAbeille(Abeille ourvriere)
        {
            bool ok = false;
            if (Ruche.abeillesDisponibles >=1)
            {
                ok = true;
                Ruche.abeillesDisponibles -= 1;
                Array.Resize(ref Ruche.ouvrieres, Ruche.ouvrieres.Length + 1);
                Ruche.ouvrieres[Ruche.ouvrieres.Length - 1] = ourvriere;
            }
            return ok;
        }

        public static void AffecteTache(string job, out string message)
        {
            bool ok = false;
            switch (job)
            {
                case "Collectrice de Nectar":
                    ok = AjouteAbeille(new Collectrice());
                    message = "1 collectrice ajoutée";
                    break;

                case "Productrice de Miel":
                    ok = AjouteAbeille(new Productrice());
                    message = "1 productrice ajoutée";
                    break;

                case "Gardienne des oeufs":
                    ok = AjouteAbeille(new Couveuse());
                    message = "1 couveuse ajoutée";
                    break;
                default:
                    throw new Exception("Job invalide");
            }

            if (!ok)
            {
                message = "Plus d'abeilles disponible";
            }
        }

        public void Pond()
        {
            Ruche.nombreOeufs +=NB_OUEUFS_PONDUS_PAR_QUART;
        }

        public override void FaitLeJob()
        {
            Ruche.alerteManqueMiel = "";
            Ruche.alerteManqueNectar = "";
            Pond();
            for (int i = 0; i < Ruche.ouvrieres.Length - 1; i++)
            {
                if (Ruche.ouvrieres[i].EffectuerLeProchainQuart())
                {
                    Ruche.alerteManqueMiel = "";
                }
                if (!Ruche.ConsommeMiel(Ruche.MIEL_CONSOMME_PAR_NON_TRAVAILLEUSES * (Ruche.abeillesDisponibles)))
                {
                    Ruche.alerteManqueMiel = "Pas assez de miel pour nourrir tout le monde, affecter des productrices !";
                }

                RapportEtatRuche = Ruche.EcritRapportQuart();
            }
        }
    }
}

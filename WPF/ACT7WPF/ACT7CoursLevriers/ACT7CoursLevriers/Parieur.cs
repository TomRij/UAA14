using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace ACT7CoursLevriers
{
    class Parieur
    {
        private string _nom;
        private Pari _monPari;
        private int _cash;
        private TextBlock _textBlock;
        private RadioButton _optParieur;

        public string Nom { get { return _nom; } set { _nom = value; } }
        public Pari MonPari { get { return _monPari; } set { _monPari = value; } }
        public int Cash { get { return _cash; } set { _cash = value; } }
        public TextBlock TextBlock { get { return _textBlock; } set { _textBlock = value; } }
        public RadioButton OptParieur { get { return _optParieur; } set { _optParieur = value; } }

        public Parieur(int cash, RadioButton optParieur, TextBlock tpb, string nom)
        {
            _optParieur = optParieur;
            _textBlock = tpb;
            _cash = cash;
            _nom = nom;
        }
        public void MajInfos()
        {
            _optParieur.Content = _nom + " possède " + _cash + " écus";
        }
        public void Parie(int valeurPari, int numChien)
        {
            _monPari = new Pari(valeurPari, numChien);
            _cash -= valeurPari;
        }
        public void GetDescriptionPari(TextBlock txtInfos)
        {
            string chaine = "";
            if (_monPari != null && _monPari.Montant != 0)
            {
                chaine = $"{this.Nom} a parié {_monPari.Montant} sur le chien #{_monPari.NumChien + 1}";
            }
            else
            {
                chaine = $"{this.Nom} n'a pas encore parié ";
            }
            txtInfos.Text = chaine;
        }
        public void ResetPari()
        {
            _monPari = null;
        }
    }
}

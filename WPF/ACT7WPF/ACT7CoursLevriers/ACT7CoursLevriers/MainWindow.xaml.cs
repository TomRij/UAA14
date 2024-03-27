using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace ACT7CoursLevriers
{
    public partial class MainWindow : Window
    {
        RadioButton[] radChoixParieur = new RadioButton[3];
        TextBlock[] txtInfosParis = new TextBlock[3];

        Chien[] coureur = new Chien[4];
        Parieur[] joueur = new Parieur[3];

        int numJoueurActif = 0;
        int[] positionChien = new int[2];

        DispatcherTimer timer = new DispatcherTimer();
        bool fini;

        public MainWindow()
        {
            InitializeComponent();
            btnParie.Click += BtnParie_Click;

            // Initialisation des joueurs et des chiens
            joueur[0] = new Parieur(50, radioButtonParieur1, textBlockParieur1, "Joe");
            joueur[1] = new Parieur(50, radioButtonParieur2, textBlockParieur2, "Bob");
            joueur[2] = new Parieur(50, radioButtonParieur3, textBlockParieur3, "Bill");

            for (int i = 0; i < 4; i++)
            {
                positionChien[0] = 0;
                positionChien[1] = i * 70;
                coureur[i] = new Chien(i, positionChien, (int)piste.Width, this);
            }

            // Démarrer le timer pour lancer la course
            timer.Interval = TimeSpan.FromMilliseconds(100);
            timer.Tick += Timer_Tick;
        }

        private void BtnParie_Click(object sender, RoutedEventArgs e)
        {
            int montantPari;
            int numChienPari;

            // Vérification de la validité des données saisies
            if (!int.TryParse(textBoxEcusPari.Text, out montantPari) || montantPari < 5 || montantPari > joueur[numJoueurActif].Cash)
            {
                MessageBox.Show("Montant de pari invalide.");
                return;
            }

            if (!int.TryParse(textBoxNumeroChienPari.Text, out numChienPari) || numChienPari < 1 || numChienPari > 4)
            {
                MessageBox.Show("Numéro de chien invalide.");
                return;
            }

            // Effectuer le pari et mettre à jour les informations
            joueur[numJoueurActif].Parie(montantPari, numChienPari - 1);
            joueur[numJoueurActif].MajInfos();
            joueur[numJoueurActif].GetDescriptionPari(txtInfosParis[numJoueurActif]);

            // Passer au joueur suivant
            numJoueurActif = (numJoueurActif + 1) % 3;
            textBlockParieurActuel.Text = "Parieur " + joueur[numJoueurActif].Nom;

            // Vérifier si tous les joueurs ont parié
            for (int i = 0; i < 3; i++)
            {
                if (joueur[i].MonPari == null || joueur[i].MonPari.Montant == 0)
                {
                    MessageBox.Show("Tous les joueurs doivent parier avant de lancer la course.");
                    return;
                }
            }

            // Démarrer la course
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            fini = true;
            for (int i = 0; i < 4; i++)
            {
                coureur[i].Court();
                if (coureur[i].Gagne)
                    fini = false;
            }
            if (fini)
            {
                timer.Stop();
                int gagnant = 0;
                for (int i = 1; i < 4; i++)
                {
                    if (coureur[i].Gagne)
                        gagnant = i + 1;
                }
                int prix = 0;
                for (int i = 0; i < 3; i++)
                {
                    prix += joueur[i].MonPari.PrixFinal(gagnant);
                    joueur[i].Cash += prix;
                    joueur[i].MajInfos();
                }
                MessageBox.Show("Le chien gagnant est le numéro " + gagnant + " ! Les parieurs gagnent " + prix + " écus !");
            }
        }
    }
}

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
using static System.Net.Mime.MediaTypeNames;
using Image = System.Windows.Controls.Image;

namespace CE_UAA14WPF24RattrapagRijckaertTom
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            TextBlock partieBasse = new TextBlock
            {
                FontWeight = FontWeights.Bold,
                FontSize = 30,
                TextAlignment = TextAlignment.Center
            };
            if (true)
            {
                partieBasse.Text = "Test WPF 2ième chance 6T 2024";
            }

            BitmapImage petitCercleRouge = new BitmapImage();
            petitCercleRouge.BeginInit();
            petitCercleRouge.UriSource = new Uri("H:\\CE_UAA14WPF24RattrapagRijckaertTom\\CE_UAA14WPF24RattrapagRijckaertTom\\CE_UAA14WPF24RattrapagRijckaertTom.csproj", UriKind.Relative);
            petitCercleRouge.EndInit();
            Image imRouge = new Image();
            imRouge.Source = petitCercleRouge;
            imRouge.Stretch = System.Windows.Media.Stretch.Fill;

            BitmapImage volvik = new BitmapImage();
            volvik.BeginInit();
            volvik.UriSource = new Uri("H:\\CE_UAA14WPF24RattrapagRijckaertTom\\CE_UAA14WPF24RattrapagRijckaertTom\\CE_UAA14WPF24RattrapagRijckaertTom.csproj", UriKind.Relative);
            volvik.EndInit();
            Image imVolvik = new Image();
            imVolvik.Source = petitCercleRouge;
            imVolvik.Stretch = System.Windows.Media.Stretch.Fill;

            grdMain.Children.Add(partieBasse);

            rdbSolitaire.Click += new RoutedEventHandler(rdbSolitaire_Click);
            rdbMarelle.Click+= new RoutedEventHandler(rdbMarelle_Click);
            rdbLaterale.Click += new RoutedEventHandler(rdbLaterale_Click);
            private void rdbMarelle_Click(object sender, RoutedEventArgs e)
            {
                    imRouge = imVolvik;
                    return imVolvik;
            }
            private void rdbSolitaire_Click(object sender, RoutedEventArgs e)
            {
                imRouge = imVolvik;
                return imVolvik;
            }
            private void rdbLaterale_Click(object sender, RoutedEventArgs e)
            {
                
            }

            btnValider.Click += new RoutedEventHandler(btnValider_Click);
            private void btnValider_Click(object sender, RoutedEventHandler e)
            {
                if (rdbMarelle_Click)
                {
                    for (int ligne = o; ligne< boxNbLigne_TextInput; ligne++) { 
                    {
                        for (int colonne = 0; i < boxNbColonnes_TextInput; colonne++)
                        {
                                return imRouge;
                        }
                    }
                }
                if (rdbSolitaire_Click)
                {
                    for (int ligne = o; ligne< boxNbLigne_TextInput; ligne++) { 
                    {
                        for (int colonne = 0; i < boxNbColonnes_TextInput; colonne++)
                        {
                                return imRouge;
                        }
                    }
                }
                if (rdbLaterale_Click)
                {
                    for (int ligne = o; ligne< boxNbLigne_TextInput; ligne++) { 
                    {
                        for (int colonne = 0; i < boxNbColonnes_TextInput; colonne++)
                        {
                                return imRouge;
                        }
                    }
                }
            }

            boxNbLigne.TextInput += new TextCompositionEventHandler(boxNbLigne_TextInput);
            boxNbColonnes.TextInput += new TextChangedEventHandler(boxNbColonnes_TextInput);

            public void boxNbLignes_TextInput(object sender, TextCompositionEventArgs e)
            {
                if (0 <= sender <= 9)
                {
                    return sender:
                }
                else {return partieBasse.Text="Vous n'avez pas entré une valeur entre 0 et 9. Veuillez recommencer svp"}

            }
        }
    }
}

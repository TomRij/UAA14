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

namespace ACT6Exo3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Button[,] textBlockMatrix;
        public MainWindow()
        {
            InitializeComponent();

            // Définition des colonnes
            ColumnDefinition[] colDefs = new ColumnDefinition[8];
            for (int i = 0; i < 8; i++)
            {
                colDefs[i] = new ColumnDefinition();
                gridMain.ColumnDefinitions.Add(colDefs[i]);
            }

            // Définition des lignes
            RowDefinition[] rowDefs = new RowDefinition[8];
            for (int i = 0; i < 8; i++)
            {
                rowDefs[i] = new RowDefinition();
                gridMain.RowDefinitions.Add(rowDefs[i]);
            }

            // Initialisation de la matrice Text
            decimal x = 0;
            textBlockMatrix = new Button[8, 8];
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    x += 1;
                    textBlockMatrix[i, j] = new Button();
                    if (i == 0 & j ==3)
                    {
                        // king
                        BitmapImage imageBouton = new BitmapImage();
                        imageBouton.BeginInit();
                        imageBouton.UriSource = new Uri("assets/k.png", UriKind.Relative);
                        imageBouton.EndInit();
                        Image imBouton = new Image();
                        imBouton.Source = imageBouton;
                        textBlockMatrix[i, j].Content = imBouton;
                    }
                    if (i == 7 & j == 3)
                    {
                        // king
                        BitmapImage imageBouton = new BitmapImage();
                        imageBouton.BeginInit();
                        imageBouton.UriSource = new Uri("assets/k.png", UriKind.Relative);
                        imageBouton.EndInit();
                        Image imBouton = new Image();
                        imBouton.Source = imageBouton;
                        textBlockMatrix[i, j].Content = imBouton;
                    }
                    if (i == 0 & j == 4)
                    {
                        // Queen
                        BitmapImage imageBouton = new BitmapImage();
                        imageBouton.BeginInit();
                        imageBouton.UriSource = new Uri("assets/q.png", UriKind.Relative);
                        imageBouton.EndInit();
                        Image imBouton = new Image();
                        imBouton.Source = imageBouton;
                        textBlockMatrix[i, j].Content = imBouton;
                    }
                    if (i == 7 & j == 4)
                    {
                        // Queen
                        BitmapImage imageBouton = new BitmapImage();
                        imageBouton.BeginInit();
                        imageBouton.UriSource = new Uri("assets/q.png", UriKind.Relative);
                        imageBouton.EndInit();
                        Image imBouton = new Image();
                        imBouton.Source = imageBouton;
                        textBlockMatrix[i, j].Content = imBouton;
                    }
                    if (i == 1 & j < 8)
                    {
                        // Pion
                        BitmapImage imageBouton = new BitmapImage();
                        imageBouton.BeginInit();
                        imageBouton.UriSource = new Uri("assets/p.png", UriKind.Relative);
                        imageBouton.EndInit();
                        Image imBouton = new Image();
                        imBouton.Source = imageBouton;
                        textBlockMatrix[i, j].Content = imBouton;
                    }
                    if (i == 6 & j < 8)
                    {
                        // Pion
                        BitmapImage imageBouton = new BitmapImage();
                        imageBouton.BeginInit();
                        imageBouton.UriSource = new Uri("assets/p.png", UriKind.Relative);
                        imageBouton.EndInit();
                        Image imBouton = new Image();
                        imBouton.Source = imageBouton;
                        textBlockMatrix[i, j].Content = imBouton;
                    }
                    if (i == 0 & j == 0)
                    {
                        // Tower
                        BitmapImage imageBouton = new BitmapImage();
                        imageBouton.BeginInit();
                        imageBouton.UriSource = new Uri("assets/t.png", UriKind.Relative);
                        imageBouton.EndInit();
                        Image imBouton = new Image();
                        imBouton.Source = imageBouton;
                        textBlockMatrix[i, j].Content = imBouton;
                    }
                    if (i == 0 & j == 7)
                    {
                        // Tower
                        BitmapImage imageBouton = new BitmapImage();
                        imageBouton.BeginInit();
                        imageBouton.UriSource = new Uri("assets/t.png", UriKind.Relative);
                        imageBouton.EndInit();
                        Image imBouton = new Image();
                        imBouton.Source = imageBouton;
                        textBlockMatrix[i, j].Content = imBouton;
                    }
                    if (i == 7 & j == 0)
                    {
                        // Tower
                        BitmapImage imageBouton = new BitmapImage();
                        imageBouton.BeginInit();
                        imageBouton.UriSource = new Uri("assets/t.png", UriKind.Relative);
                        imageBouton.EndInit();
                        Image imBouton = new Image();
                        imBouton.Source = imageBouton;
                        textBlockMatrix[i, j].Content = imBouton;
                    }
                    if (i == 7 & j == 0)
                    {
                        // Tower
                        BitmapImage imageBouton = new BitmapImage();
                        imageBouton.BeginInit();
                        imageBouton.UriSource = new Uri("assets/t.png", UriKind.Relative);
                        imageBouton.EndInit();
                        Image imBouton = new Image();
                        imBouton.Source = imageBouton;
                        textBlockMatrix[i, j].Content = imBouton;
                    }
                    if (i == 0 & j == 2)
                    {
                        // Fou
                        BitmapImage imageBouton = new BitmapImage();
                        imageBouton.BeginInit();
                        imageBouton.UriSource = new Uri("assets/kn.png", UriKind.Relative);
                        imageBouton.EndInit();
                        Image imBouton = new Image();
                        imBouton.Source = imageBouton;
                        textBlockMatrix[i, j].Content = imBouton;
                    }
                    if (i == 0 & j == 5)
                    {
                        // Fou
                        BitmapImage imageBouton = new BitmapImage();
                        imageBouton.BeginInit();
                        imageBouton.UriSource = new Uri("assets/kn.png", UriKind.Relative);
                        imageBouton.EndInit();
                        Image imBouton = new Image();
                        imBouton.Source = imageBouton;
                        textBlockMatrix[i, j].Content = imBouton;
                    }
                    if (i == 7 & j == 2)
                    {
                        // Fou
                        BitmapImage imageBouton = new BitmapImage();
                        imageBouton.BeginInit();
                        imageBouton.UriSource = new Uri("assets/kn.png", UriKind.Relative);
                        imageBouton.EndInit();
                        Image imBouton = new Image();
                        imBouton.Source = imageBouton;
                        textBlockMatrix[i, j].Content = imBouton;
                    }
                    if (i == 7 & j == 5)
                    {
                        // Fou
                        BitmapImage imageBouton = new BitmapImage();
                        imageBouton.BeginInit();
                        imageBouton.UriSource = new Uri("assets/kn.png", UriKind.Relative);
                        imageBouton.EndInit();
                        Image imBouton = new Image();
                        imBouton.Source = imageBouton;
                        textBlockMatrix[i, j].Content = imBouton;
                    }
                    if (i == 0 & j == 1)
                    {
                        // Cavalier
                        BitmapImage imageBouton = new BitmapImage();
                        imageBouton.BeginInit();
                        imageBouton.UriSource = new Uri("assets/kn.png", UriKind.Relative);
                        imageBouton.EndInit();
                        Image imBouton = new Image();
                        imBouton.Source = imageBouton;
                        textBlockMatrix[i, j].Content = imBouton;
                    }
                    if (i == 0 & j == 6)
                    {
                        // Cavalier
                        BitmapImage imageBouton = new BitmapImage();
                        imageBouton.BeginInit();
                        imageBouton.UriSource = new Uri("assets/kn.png", UriKind.Relative);
                        imageBouton.EndInit();
                        Image imBouton = new Image();
                        imBouton.Source = imageBouton;
                        textBlockMatrix[i, j].Content = imBouton;
                    }
                    if (i == 7 & j == 1)
                    {
                        // Cavalier
                        BitmapImage imageBouton = new BitmapImage();
                        imageBouton.BeginInit();
                        imageBouton.UriSource = new Uri("assets/kn.png", UriKind.Relative);
                        imageBouton.EndInit();
                        Image imBouton = new Image();
                        imBouton.Source = imageBouton;
                        textBlockMatrix[i, j].Content = imBouton;
                    }
                    if (i == 7 & j == 6)
                    {
                        // Cavalier
                        BitmapImage imageBouton = new BitmapImage();
                        imageBouton.BeginInit();
                        imageBouton.UriSource = new Uri("assets/kn.png", UriKind.Relative);
                        imageBouton.EndInit();
                        Image imBouton = new Image();
                        imBouton.Source = imageBouton;
                        textBlockMatrix[i, j].Content = imBouton;
                    }
                    if ((i + j) % 2 == 0)
                    {
                        textBlockMatrix[i, j].Background = Brushes.White;
                    }
                    else
                    {
                        textBlockMatrix[i, j].Background = Brushes.Black;
                    }

                    

                    Grid.SetRow(textBlockMatrix[i, j], i);
                    Grid.SetColumn(textBlockMatrix[i, j], j);
                    gridMain.Children.Add(textBlockMatrix[i, j]);

                }
            }
        }
    }
}

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

namespace ACT6Exo1
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
            ColumnDefinition[] colDefs = new ColumnDefinition[10];
            for (int i = 0; i < 10; i++) 
            {
                colDefs[i] = new ColumnDefinition();
                gridMain.ColumnDefinitions.Add(colDefs[i]);
            }

            // Définition des lignes
            RowDefinition[] rowDefs = new RowDefinition[10];
            for(int i = 0;i < 10;i++)
            {
                rowDefs[i] = new RowDefinition();
                gridMain.RowDefinitions.Add(rowDefs[i]);
            }

            // Initialisation de la matrice Text
            decimal x = 0;
            textBlockMatrix = new Button[10, 10];
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    x += 1;
                    textBlockMatrix[i, j] = new Button();
                    textBlockMatrix[i, j].Content = x.ToString();
                    textBlockMatrix[i, j].FontSize = 20;
                    textBlockMatrix[i, j].Foreground = Brushes.Red;

                    if ((i + j) % 2 == 0)
                    {
                        textBlockMatrix[i, j].Background = Brushes.Black;
                    }
                    else
                    {
                        textBlockMatrix[i, j].Background = Brushes.White;
                    }

                    Grid.SetRow(textBlockMatrix[i, j], i);
                    Grid.SetColumn(textBlockMatrix[i, j], j);
                    gridMain.Children.Add(textBlockMatrix[i, j]);
                }
            }
        }
    }
}

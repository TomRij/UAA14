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

namespace ACT4Exo2
{
    public partial class MainWindow : Window
    {
        private TextBlock[,] textBlockMatrix;

        public MainWindow()
        {
            InitializeComponent();

            // Définition des colonnes
            ColumnDefinition[] colDefs = new ColumnDefinition[4];
            for (int i = 0; i < 4; i++)
            {
                colDefs[i] = new ColumnDefinition();
                gridMain.ColumnDefinitions.Add(colDefs[i]);
            }

            // Définition des lignes
            RowDefinition[] rowDefs = new RowDefinition[4];
            for (int i = 0; i < 4; i++)
            {
                rowDefs[i] = new RowDefinition();
                gridMain.RowDefinitions.Add(rowDefs[i]);
            }

            // Initialisation de la matrice de TextBlocks
            textBlockMatrix = new TextBlock[4, 4];
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    textBlockMatrix[i, j] = new TextBlock();
                    textBlockMatrix[i, j].Text = "?";
                    textBlockMatrix[i, j].FontSize = 20;
                    textBlockMatrix[i, j].Foreground = Brushes.Black;
                    textBlockMatrix[i, j].MouseDown += TextBlock_MouseDown;

                    Grid.SetRow(textBlockMatrix[i, j], i);
                    Grid.SetColumn(textBlockMatrix[i, j], j);
                    gridMain.Children.Add(textBlockMatrix[i, j]);
                }
            }
        }

        private void TextBlock_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (sender is TextBlock textBlock)
            {
                // Remplace le "?" par "X" lorsqu'on clique sur le TextBlock
                textBlock.Text = "X";
            }
        }
    }
}
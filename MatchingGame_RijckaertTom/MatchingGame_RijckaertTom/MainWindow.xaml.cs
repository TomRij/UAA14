using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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

namespace MatchingGame_RijckaertTom
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();





        }

        private void SetUpGame()
            {
                List<string> animalEmoji = new List<string>()
                    {
                        "🐈","🐈",
                        "🐷","🐷",
                        "🐐","🐐",
                        "🦊","🦊",
                        "🐴","🐴",
                        "🦨","🦨",
                        "🦉","🦉",
                        "🐀","🐀",
                    };

            int index;
            string nextEmoji;
            Random alea = new Random();
                foreach (TextBlock textBlock in grdMain.Children.OfType<TextBlock>())
                {
                    index = alea.Next(animalEmoji.Count); // index est de type int
                                                            // nbalea est un objet de type Random()
                    nextEmoji = animalEmoji[index]; // nextEmoji est de type string
                    textBlock.Text = nextEmoji;
                    animalEmoji.RemoveAt(index); // on retire un animal de la liste pour ne pas l’attribuer à nouveau.
                }
            }

    }
}

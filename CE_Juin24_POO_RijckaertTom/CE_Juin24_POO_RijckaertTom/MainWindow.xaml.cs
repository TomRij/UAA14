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

namespace CE_Juin24_POO_RijckaertTom
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Reine queen;
        public MainWindow()
        {
            InitializeComponent();

            queen = new Reine();

            btnAttribuer.Click += BtnAttribuer_Click;
            btnLancer.Click += BtnLancer_Click;
        }

        private void BtnLancer_Click(object sender, RoutedEventArgs e)
        {
            queen.FaitLeJob();
            txtRapport.Text = queen.RapportEtatRuche;
        }

        private void BtnAttribuer_Click(object sender, RoutedEventArgs e)
        {
            string message = "";
            Reine.AffecteTache(cmbTypeJob.Text, out message);
            txtRapport.Text = message;
        }
    }
}
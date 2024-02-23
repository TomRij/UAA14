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

namespace CE_UAA14WPF24_RijckaertTpù
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            TextBlock txt = new TextBlock();
            txt.Text = "VERIFIONS VOS CONNAISSANCES en WPF !";
            txt.FontSize = 34;
            txt.Foreground = Brushes.Green; 
            txt.HorizontalAlignment = HorizontalAlignment.Center;
            grdMain.Children.Add(txt);
            
            StackPanel stk = new StackPanel();

            ColumnDefinition col1 = new ColumnDefinition();
            ColumnDefinition col2 = new ColumnDefinition();
            grdMain.ColumnDefinitions.Add(col1);
            grdMain.ColumnDefinitions.Add(col2);
            RowDefinition row1 = new RowDefinition();
            RowDefinition row2 = new RowDefinition();
            RowDefinition row3 = new RowDefinition();
            grdMain.RowDefinitions.Add(row1);
            grdMain.RowDefinitions.Add(row2);
            grdMain.RowDefinitions.Add(row3);
            Grid.SetRow(stk, 1);
            Grid.SetColumn(stk, 1);
            grdMain.Children.Add(stk);
            stk.Background= Brushes.Green;
            


        }
    }
}

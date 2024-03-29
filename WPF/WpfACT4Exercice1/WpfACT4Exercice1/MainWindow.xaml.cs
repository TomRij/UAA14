﻿using System;
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
using System.Windows.Media.Media3D;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfACT4Exercice1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Thickness myThickness = new Thickness();
            myThickness.Bottom = 20;
            myThickness.Left = 20;
            myThickness.Right = 20;
            myThickness.Top = 20;

            ColumnDefinition coldef1 = new ColumnDefinition();
            ColumnDefinition coldef2 = new ColumnDefinition();
            ColumnDefinition coldef3 = new ColumnDefinition();
            grdMain.ColumnDefinitions.Add(coldef1);
            grdMain.ColumnDefinitions.Add(coldef2);
            grdMain.ColumnDefinitions.Add(coldef3);
            RowDefinition rowDef1 = new RowDefinition();
            RowDefinition rowDef2 = new RowDefinition();
            RowDefinition rowDef3 = new RowDefinition();
            grdMain.RowDefinitions.Add(rowDef1);
            grdMain.RowDefinitions.Add(rowDef2);
            grdMain.RowDefinitions.Add(rowDef3);


            StackPanel stkBloc1 = new StackPanel();
            TextBlock txtBMonTexte = new TextBlock();
            txtBMonTexte.Text = "Texte créé dynamiquement";
            txtBMonTexte.FontFamily = new FontFamily("airal");
            txtBMonTexte.FontSize = 20;
            txtBMonTexte.FontWeight = FontWeights.UltraBold;
            txtBMonTexte.Foreground = Brushes.Green;
            txtBMonTexte.Background = Brushes.Black;
            stkBloc1.Children.Add(txtBMonTexte);

            StackPanel stkFusion = new StackPanel();


            Button btnB = new Button();
            btnB.Content = "Calculer";
            Button btnB2 = new Button();
            btnB2.Content = "Calculer";
            Button btnB3 = new Button();
            btnB3.Content = "Calculer";
            btnB.Height = 100;
            btnB.Width = 100;
            btnB.VerticalAlignment = VerticalAlignment.Bottom;
            btnB2.Height = 100;
            btnB2.Width = 100;
            btnB2.VerticalAlignment = VerticalAlignment.Bottom; btnB.Height = 100;
            btnB3.Height = 100;
            btnB3.Width = 100;
            btnB3.VerticalAlignment = VerticalAlignment.Bottom; btnB.Height = 100;

            Grid.SetRow(stkBloc1, 0);
            Grid.SetColumn(stkBloc1, 0);
            Grid.SetColumnSpan(stkBloc1, 3);
            grdMain.Children.Add(stkBloc1);

            Grid.SetRow(btnB, 1);
            Grid.SetColumn(btnB, 0);
            Grid.SetRow(btnB2, 1);
            Grid.SetColumn(btnB2, 1);
            Grid.SetRow(btnB3, 1);
            Grid.SetColumn(btnB3, 2);
            grdMain.Children.Add(btnB);
            grdMain.Children.Add(btnB2);
            grdMain.Children.Add(btnB3);

            stkFusion.Margin = myThickness;

            // 3e partie (truc fusionné)
            TextBlock txtBloc2 = new TextBlock();
            txtBloc2.Text = "Infos:";
            txtBloc2.FontFamily = new FontFamily("Arial");
            txtBloc2.FontSize = 18;
            txtBloc2.Foreground = Brushes.Blue;
            txtBloc2.Background = Brushes.Yellow;
           

            TextBox txtBox = new TextBox();
            txtBox.Text = "j'attend vos infos";
            txtBox.FontFamily = new FontFamily("Arial");
            txtBox.FontSize = 16;
            txtBox.Height = 30;

            ComboBox comboBox = new ComboBox();
            comboBox.Items.Add("Item 1");
            comboBox.Items.Add("Item 2");

            stkFusion.Children.Add(txtBloc2);
            stkFusion.Children.Add(txtBox);

            Grid.SetRow(stkFusion, 2);
            Grid.SetColumn(stkFusion, 0);
            Grid.SetColumnSpan(stkFusion, 2);
            grdMain.Children.Add(stkFusion);

            Grid.SetRow(comboBox, 2);
            Grid.SetColumn(comboBox, 2);
            grdMain.Children.Add(comboBox);


        }
    }
}

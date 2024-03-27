using System;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace ACT7CoursLevriers
{
    class Chien
    {
        private int _longueurPiste;
        private int _numChien;
        private Image _imageChien;
        private int[] _positionCourante;
        private bool _gagne;
        private MainWindow _mainWindow;

        public bool Gagne // Propriété pour vérifier si le chien a gagné
        {
            get { return _gagne; }
        }

        public Chien(int numeroChien, int[] position, int longueurPiste, MainWindow mainWindow)
        {
            _longueurPiste = longueurPiste;
            _numChien = numeroChien;
            _positionCourante = new int[2];
            _positionCourante[0] = position[0];
            _positionCourante[1] = position[1];
            _gagne = false;
            _mainWindow = mainWindow;

            // création de l'image
            BitmapImage imageChien = new BitmapImage();
            imageChien.BeginInit();
            imageChien.UriSource = new Uri("C:\\Users\\Tom\\OneDrive\\Documents\\école\\6e\\Info\\UAA14\\WPF\\ACT7WPF\\ACT7CoursLevriers\\ACT7CoursLevriers\\assets\\dog.png");
            imageChien.EndInit();

            _imageChien = new Image();
            _imageChien.Source = imageChien;
            _imageChien.Stretch = System.Windows.Media.Stretch.None;

            Canvas.SetLeft(_imageChien, position[0]);
            Canvas.SetTop(_imageChien, position[1]);
            _mainWindow.piste.Children.Add(_imageChien);
        }

        public void Court()
        {
            int pas = (int)(_longueurPiste / 40);
            Random alea = new Random();
            int nbPas;
            nbPas = alea.Next(1, 10);
            _positionCourante[0] += nbPas * pas;
            if (_positionCourante[0] >= _longueurPiste - 75)
            {
                _positionCourante[0] = _longueurPiste - 75;
                _gagne = true;
            }
            //avancer l'image
            Canvas.SetLeft(_imageChien, _positionCourante[0]);
            Canvas.SetTop(_imageChien, _positionCourante[1]);
        }
    }
}

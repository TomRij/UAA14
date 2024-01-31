namespace HeritageExo3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Carre
            Carre carre = new Carre(5, "rouge");
            Console.WriteLine(carre.Afficher());

            // Rectangle
            Rectangle rectangle = new Rectangle();
            rectangle.Longueur = 4;
            rectangle.Largeur = 6;
            rectangle.Couleur = "bleu";
            Console.WriteLine(rectangle.Afficher());
        }
    }
}
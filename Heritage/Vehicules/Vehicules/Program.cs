namespace Vehicules
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Velo velo1 = new Velo("VTT", true, "ModelX", "VeloBrand", "Red", 500);

            Velo velo2 = new Velo("Ville", false, "CityBike", "AnotherBrand", "Blue", 400);

            Voiture voiture1 = new Voiture("Essence", true, "Sedan", "CarBrand", "Black", 25000);

            Voiture voiture2 = new Voiture("Electrique", false, "ElectricCar", "ElectricBrand", "White", 35000);

            Console.WriteLine(velo1.Affiche());
            Console.WriteLine(velo2.Affiche());
            Console.WriteLine(voiture1.Affiche());
            Console.WriteLine(voiture2.Affiche());
        }
    }
}
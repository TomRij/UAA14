namespace HeritageExo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Chat chat = new Chat("Minou", "01/01/2022", 123456, true);
            Console.WriteLine(chat.Affiche());

            Lapin lapin = new Lapin(20.5m, "Victor", "05/05/2021", 789012, false);
            Console.WriteLine(lapin.Affiche());

            Chien chien = new Chien("Rex", "10/10/2019", 345678, true);
            Console.WriteLine(chien.Affiche());
        }
    }
}
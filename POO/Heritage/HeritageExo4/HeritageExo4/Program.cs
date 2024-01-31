namespace HeritageExo4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Création tableau de 10 personnes
            Employe[] employes = new Employe[10];

            // cinq ouvriers
            employes[0] = new Ouvrier("111", "Dupont", "Jean", new DateTime(1980, 5, 10), new DateTime(2010, 3, 15), 5);
            employes[1] = new Ouvrier("222", "Martin", "Paul", new DateTime(1985, 8, 20), new DateTime(2012, 6, 25), 8);
            employes[2] = new Ouvrier("333", "Durand", "Marie", new DateTime(1990, 11, 8), new DateTime(2015, 9, 5), 3);
            employes[3] = new Ouvrier("444", "Lefevre", "Luc", new DateTime(1975, 2, 15), new DateTime(2008, 12, 10), 12);
            employes[4] = new Ouvrier("555", "Leclerc", "Sophie", new DateTime(1988, 7, 3), new DateTime(2017, 1, 30), 7);

            // trois cadres
            employes[5] = new Cadre("666", "Gauthier", "Pierre", new DateTime(1970, 12, 5), 2);
            employes[6] = new Cadre("777", "Fournier", "Isabelle", new DateTime(1982, 3, 18), 3);
            employes[7] = new Cadre("888", "Roux", "Patrick", new DateTime(1978, 9, 22), 4);

            // deux directeurs
            employes[8] = new Directeur("999", "Moreau", "Catherine", new DateTime(1965, 6, 12), 5000000, 0.05);
            employes[9] = new Directeur("000", "Lemoine", "Jean", new DateTime(1962, 10, 30), 8000000, 0.03);

            // Affichage des caractéristiques de chaque personne
            foreach (Employe employe in employes)
            {
                Console.WriteLine(employe.Afficher());
                Console.WriteLine("------------------------");
            }
        }
    }
}

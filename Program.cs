namespace Bases_POO
{
    internal class Program
    {
        public static void testPolymorphismeHeritage()
        {
            Personne p1 = new Personne(1, "Sanchis", "Brian", new DateTime(2000, 05, 24));
            p1.show();
            Etudiant e1 = new Etudiant(2, "Rosat", "Aurélien", new DateTime(2001, 07, 12), "002");
            e1.show();
        }
        static void Main(string[] args)
        {
            testPolymorphismeHeritage();
        }
    }
}
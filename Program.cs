namespace Bases_POO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Personne p1 = new Personne(1, "Sanchis", "Brian", new DateTime(2000, 05, 24));
            p1.show();
        }
    }
}
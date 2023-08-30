namespace Bases_POO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Personne p1 = new Personne(23, "Sanchis", "Brian");
            p1.show();
        }
    }
}
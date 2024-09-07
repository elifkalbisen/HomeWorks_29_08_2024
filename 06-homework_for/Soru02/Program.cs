namespace Soru02;

class Program
{
    static void Main(string[] args)
    {
        for (int i = 1; i <= 10; i++)
        {

            Console.WriteLine($"{i}'ler");
            Console.WriteLine("----------");

            for (int j = 1; j <= 10; j++)
            {
                Console.WriteLine($"{i}x{j}={i * j}");
            }

            Console.WriteLine();
        }
    }
}

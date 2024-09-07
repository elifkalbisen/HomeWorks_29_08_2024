namespace Soru08;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Bir sayı girin: ");
        if (!int.TryParse(Console.ReadLine(), out int limit) || limit < 0)
        {
            Console.WriteLine("Geçerli bir pozitif sayı girin.");
            return;
        }
        int a = 0;
        int b = 1;

        Console.Write("Fibonacci serisi: ");
        if (limit >= a)
        {
            Console.Write(a);
        }
        for (int i = b; i <= limit; i = a + b)
        {
            Console.Write($", {i}");
            a = b;
            b = i;
        }

        Console.WriteLine();
    }
}

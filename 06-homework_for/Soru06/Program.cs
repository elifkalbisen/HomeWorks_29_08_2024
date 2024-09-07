namespace Soru06;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Bir sayı girin: ");
        if (!int.TryParse(Console.ReadLine(), out int number) || number <= 0)
        {
            Console.WriteLine("Geçerli bir pozitif sayı girin.");
            return;
        }
        int count = 0;


        for (int i = 1; i <= number; i++)
        {
            if (number % i == 0)
            {
                count++;
            }
        }

        Console.WriteLine($"Sayının pozitif bölen sayısı: {count}");
    }
}

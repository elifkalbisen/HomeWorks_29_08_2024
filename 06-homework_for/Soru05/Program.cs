namespace Soru05;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Bir sayı girin: ");
        if (!int.TryParse(Console.ReadLine(), out int number) || number < 0)
        {
            Console.WriteLine("Geçerli bir pozitif sayı girin.");
            return;
        }

        int originalNumber = number;
        int reversedNumber = 0; 
        for (; number > 0; number /= 10)
        {
            int digit = number % 10; 
            reversedNumber = reversedNumber * 10 + digit;
        }

        Console.WriteLine($"Sayı: {originalNumber}");
        Console.WriteLine($"Sonuç: {reversedNumber}");
    }
}

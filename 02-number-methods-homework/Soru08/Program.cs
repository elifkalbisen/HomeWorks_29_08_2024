namespace Soru08;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Bir sayı girin: ");
        string input = Console.ReadLine();
        
        double sayi;
        if (double.TryParse(input, out sayi))
        {

            if (sayi > 0)
            {
                double logaritma = Math.Log(sayi);
                
                Console.WriteLine($"Sayının doğal logaritması: {logaritma:F4}");
            }
            else
            {
                Console.WriteLine("Doğal logaritması hesaplanabilir pozitif bir sayı girin.");
            }
        }
        else
        {
            Console.WriteLine("Geçerli bir sayı girin.");
        }
    }
}

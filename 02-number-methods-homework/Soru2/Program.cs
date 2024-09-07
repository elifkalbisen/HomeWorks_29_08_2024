using System.Buffers;
using System.Diagnostics.CodeAnalysis;

namespace Soru2;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Birinci sayıyı girin:");
        int sayi1 = int.Parse(Console.ReadLine());
        Console.WriteLine("İkinci sayıyı girin:");
        int sayi2 = int.Parse(Console.ReadLine());

        double largerNumber = Math.Max(sayi1, sayi2);
        double smallerNumber = Math.Min(sayi1, sayi2);


        Console.WriteLine($"Daha büyük sayı: {largerNumber}\nDaha küçük sayı: {smallerNumber}");
        
    }
}

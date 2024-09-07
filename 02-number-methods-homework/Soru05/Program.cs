namespace Soru05;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Birinci sayıyı girin: ");
        int tabanSayisi = int.Parse(Console.ReadLine());

        Console.Write("İkinci sayıyı girin (üssü): ");
        int ustSayi = int.Parse(Console.ReadLine());

        double result = Math.Pow(tabanSayisi, ustSayi);
        
        Console.WriteLine($"{tabanSayisi} üssü {ustSayi} = {result}");
    }
}

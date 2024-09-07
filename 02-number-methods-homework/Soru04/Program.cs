namespace Soru04;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Sayıyı giriniz: ");
        int sayi1 = int.Parse(Console.ReadLine());
        double karekok = Math.Sqrt(sayi1);
        Console.WriteLine("Karakök Değeri: " + karekok);
    }
}

namespace Soru03;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Birinci sayıyı girin: ");
        int sayi1 = int.Parse(Console.ReadLine());
        int mutlak = (int)Math.Abs(sayi1);
        Console.WriteLine("Mutlak Değeri: " + mutlak);
    }
}

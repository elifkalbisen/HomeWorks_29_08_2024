namespace Soru02;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bir Cümle Giriniz : ");
        string cumle = Console.ReadLine();
        string buyukCumle = cumle.ToUpper();
        string kucukCumle = cumle.ToLower();
        System.Console.WriteLine($"Cümlenizin büyük yazılımı : {buyukCumle}\nCümlenizin küçük yazılımı : {kucukCumle}");
    }
}

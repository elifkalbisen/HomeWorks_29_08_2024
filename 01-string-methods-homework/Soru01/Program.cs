namespace Soru01;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Lütfen Bir Cümle Giriniz : ");
        string cumle = Console.ReadLine();
        string[] kelime = cumle.Split(" "); 
        Console.WriteLine("Kelime Sayısı: " + kelime.Length);
    }
}

namespace Soru07;

class Program
{
    static void Main(string[] args)
    {
        
        Console.Write("1 ile 5 arasında bir sayı girin (1=1 Kr, 2=5 Kr, 3=10 Kr, 4=25 Kr, 5=50 Kr): ");
        if (!int.TryParse(Console.ReadLine(), out int paraBirimi) || paraBirimi < 1 || paraBirimi > 5)
        {
            Console.WriteLine("Geçerli bir sayı girin (1 ile 5 arasında).");
            return;
        }

        
        string paraBirimiAdı;
        switch (paraBirimi)
        {
            case 1:
                paraBirimiAdı = "1 Kr";
                break;
            case 2:
                paraBirimiAdı = "5 Kr";
                break;
            case 3:
                paraBirimiAdı = "10 Kr";
                break;
            case 4:
                paraBirimiAdı = "25 Kr";
                break;
            case 5:
                paraBirimiAdı = "50 Kr";
                break;
            default:
                paraBirimiAdı = "Geçersiz para birimi";
                break;
        }

        
        Console.WriteLine($"Seçilen para birimi: {paraBirimiAdı}");
    }
}

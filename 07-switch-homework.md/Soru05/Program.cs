namespace Soru05;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("1 ile 4 arasında bir sayı girin (1=İlkbahar, 2=Yaz, 3=Sonbahar, 4=Kış): ");
        if (!int.TryParse(Console.ReadLine(), out int mevsimNumarası) || mevsimNumarası < 1 || mevsimNumarası > 4)
        {
            Console.WriteLine("Geçerli bir sayı girin (1 ile 4 arasında).");
            return;
        }

        string mevsimAdı;
        switch (mevsimNumarası)
        {
            case 1:
                mevsimAdı = "İlkbahar";
                break;
            case 2:
                mevsimAdı = "Yaz";
                break;
            case 3:
                mevsimAdı = "Sonbahar";
                break;
            case 4:
                mevsimAdı = "Kış";
                break;
            default:
                mevsimAdı = "Geçersiz mevsim";
                break;
        }

        Console.WriteLine($"Seçilen mevsim: {mevsimAdı}");
    }
}

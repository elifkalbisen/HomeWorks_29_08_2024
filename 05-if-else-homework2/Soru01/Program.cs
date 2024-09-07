namespace Soru01;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Para değerini girin (TL): ");

        if (double.TryParse(Console.ReadLine(), out double para) && para >= 0)
        {

            double kdvOrani;
            if (para <= 1000)
            {
                kdvOrani = 0.20;
            }
            else
            {
                kdvOrani = 0.08;
            }


            double kdvTutarı = para * kdvOrani;
            double kdvliFiyat = para + kdvTutarı;

            Console.WriteLine($"KDV Oranı: {kdvOrani * 100}%");
            Console.WriteLine($"KDV Tutarı: {kdvTutarı:C2}");
            Console.WriteLine($"KDV'li Fiyat: {kdvliFiyat:C2}");
        }
        else
        {
            Console.WriteLine("Geçerli bir para değeri girmediniz.");
        }
    }
}

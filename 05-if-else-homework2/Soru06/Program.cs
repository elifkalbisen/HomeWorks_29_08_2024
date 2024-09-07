namespace Soru06;

class Program
{
    static void Main(string[] args)
    {
        const double armutFiyat = 45.50;
        const double bamyaFiyat = 81.40;
        const double domatesFiyat = 45.00;
        const double muzFiyat = 65.00;
        const double patlicanFiyat = 45.00;

        Console.Write("Armut kaç kilogram? ");
        if (double.TryParse(Console.ReadLine(), out double armutKg) && armutKg >= 0)
        {
            Console.Write("Bamya kaç kilogram? ");
            if (double.TryParse(Console.ReadLine(), out double bamyaKg) && bamyaKg >= 0)
            {
                Console.Write("Domates kaç kilogram? ");
                if (double.TryParse(Console.ReadLine(), out double domatesKg) && domatesKg >= 0)
                {
                    Console.Write("Muz kaç kilogram? ");
                    if (double.TryParse(Console.ReadLine(), out double muzKg) && muzKg >= 0)
                    {
                        Console.Write("Patlıcan kaç kilogram? ");
                        if (double.TryParse(Console.ReadLine(), out double patlicanKg) && patlicanKg >= 0)
                        {

                            double toplamTutar = (armutKg * armutFiyat) +
                                                 (bamyaKg * bamyaFiyat) +
                                                 (domatesKg * domatesFiyat) +
                                                 (muzKg * muzFiyat) +
                                                 (patlicanKg * patlicanFiyat);
                            Console.WriteLine($"Toplam tutar: {toplamTutar:F2} TL");
                        }
                        else
                        {
                            Console.WriteLine("Geçerli bir Patlıcan kilogramı girin.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Geçerli bir Muz kilogramı girin.");
                    }
                }
                else
                {
                    Console.WriteLine("Geçerli bir Domates kilogramı girin.");
                }
            }
            else
            {
                Console.WriteLine("Geçerli bir Bamya kilogramı girin.");
            }
        }
        else
        {
            Console.WriteLine("Geçerli bir Armut kilogramı girin.");
        }
    }
}

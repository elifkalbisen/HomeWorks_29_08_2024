namespace Soru06;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Bir yıl girin: ");
        string inputYear = Console.ReadLine();
        bool isValidYear = int.TryParse(inputYear, out int year);

        if (isValidYear)
        {
            bool isLeapYear = DateTime.IsLeapYear(year);

            if (isLeapYear)
            {
                Console.WriteLine($"{year} yılı bir artık yıldır.");
            }
            else
            {
                Console.WriteLine($"{year} yılı bir artık yıl değildir.");
            }
        }
        else
        {
            Console.WriteLine("Geçersiz yıl. Lütfen geçerli bir tam sayı girin.");
        }
    }
}

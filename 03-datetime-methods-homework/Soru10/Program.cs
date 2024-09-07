namespace Soru10;

class Program
{
    static void Main(string[] args)
    {

        Console.Write("12 saat formatında saati girin (hh:mm tt): ");
        string saat12Input = Console.ReadLine();

        if (DateTime.TryParse(saat12Input, out DateTime saat24))
        {
            string saat24Format = saat24.ToString("HH:mm");
            Console.WriteLine("24 saat formatındaki saat: " + saat24Format);
        }
        else
        {
            Console.WriteLine("Geçersiz format. Lütfen hh:mm tt formatında saat girin.");
        }
    }
}

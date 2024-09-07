namespace Soru03;

class Program
{
    static void Main(string[] args)
    {

        const double acilisUcreti = 30.0; 
        const double kmBasinaUcret = 20.0;
        const double minimumUcret = 100.0;

        
        Console.Write("Gidilen mesafeyi kilometre olarak girin: ");

        if (double.TryParse(Console.ReadLine(), out double mesafe) && mesafe >= 0)
        {
            double taksimetreTutari = acilisUcreti + (mesafe * kmBasinaUcret);

            if (taksimetreTutari < minimumUcret)
            {
                taksimetreTutari = minimumUcret;
            }

            Console.WriteLine($"Gidilen mesafe: {mesafe} km");
            Console.WriteLine($"Taksimetre tutarı: {taksimetreTutari:F2} TL");
        }
        else
        {
            Console.WriteLine("Geçerli bir mesafe girmediniz.");
        }
    }
}

namespace Soru05;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Birinci kenarın uzunluğunu girin: ");
        int kenar1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("İkinci kenarın uzunluğunu girin: ");
        int kenar2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Üçüncü kenarın uzunluğunu girin: ");
        int kenar3 = Convert.ToInt32(Console.ReadLine());

        
        bool ucgenOlusturabilirMi = (kenar1 + kenar2 > kenar3) &&
                                    (kenar1 + kenar3 > kenar2) &&
                                    (kenar2 + kenar3 > kenar1);

        
        if (ucgenOlusturabilirMi)
        {
            Console.WriteLine("Bu kenar uzunlukları bir üçgen oluşturabilir.");
        }
        else
        {
            Console.WriteLine("Bu kenar uzunlukları bir üçgen oluşturamaz.");
        }
    }
}

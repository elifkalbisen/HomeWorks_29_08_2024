namespace Soru05;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Lütfen Bir Metin Giriniz : ");
        string metin = Console.ReadLine();
        
        Console.WriteLine("Lütfen Aranacak Metni Giriniz : ");
        string aranacakMetin = Console.ReadLine();
        //string[] noktadanAyırma = metin.Split("."); 
        //int sayac = 0;        
        if (metin.Contains(aranacakMetin))
        {
            int indeks = metin.IndexOf(aranacakMetin);
            Console.WriteLine("Aranan metin ilk olarak {0} indeksinde bulundu.", indeks);
        }else
        {
            Console.WriteLine($"Aradığınız metin, yazdığınız metinde bulunmamaktadir.");
        }
        
        
    }
}

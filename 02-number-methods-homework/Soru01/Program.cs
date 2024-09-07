namespace Soru01;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Lütfen Ondalıklı sayınızı giriniz (virgül kullanın): ");
        
        if(double.TryParse(Console.ReadLine(), out double ondaliklisayi))
        {
            int yuvarlanmisSayi = (int)Math.Round(ondaliklisayi);
            Console.WriteLine("En Yakın Tam Sayı : "+ yuvarlanmisSayi);
        }
        else
        {
            Console.WriteLine("Geçerli bir ondalıklı sayi giriniz.");
        }

        
    }
}

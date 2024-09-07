namespace Soru10;

class Program
{
    static void Main(string[] args)
    {
        
        Console.Write("Ondalıklı bir sayı girin: ");
        string inputNumber = Console.ReadLine();
        
        
        Console.Write("Ondalık basamak sayısını girin: ");
        string inputNumber2 = Console.ReadLine();

        if (double.TryParse(inputNumber, out double number) && int.TryParse(inputNumber2, out int ondalik))
        {
            
            if (ondalik >= 0)
            {
                double yuvarlananSayi = Math.Round(number, ondalik);
                
                Console.WriteLine($"Yuvarlanmış sayı: {yuvarlananSayi}");
            }
            else
            {
                Console.WriteLine("Ondalık basamak sayısı negatif olamaz.");
            }
        }
    }
}

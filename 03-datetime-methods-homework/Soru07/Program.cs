namespace Soru07;

class Program
{
    static void Main(string[] args)
    {       
        Console.Write("Tarihi girin (dd/MM/yyyy formatında): ");
        string inputDate = Console.ReadLine();
                
        bool isValidDate = DateTime.TryParse(inputDate, out DateTime parsedDate);


        if (isValidDate)
        {

            Console.WriteLine($"Girilen tarih: {parsedDate:dd/MM/yyyy}");
        }
        else
        {

            Console.WriteLine("Geçersiz tarih formatı. Lütfen dd/MM/yyyy formatında bir tarih girin.");
        }
    } 
}

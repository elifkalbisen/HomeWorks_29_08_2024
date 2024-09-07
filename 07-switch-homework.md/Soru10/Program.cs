namespace Soru10;

class Program
{
    static void Main(string[] args)
    {

        Console.Write("Bir matematiksel işlem karakteri girin (+, -, *, /, %): ");
        char islem = Console.ReadKey().KeyChar;

        Console.WriteLine();
        switch (islem)
        {
            case '+':
                Console.WriteLine("Toplama işlemi");
                break;
            case '-':
                Console.WriteLine("Çıkarma işlemi");
                break;
            case '*':
                Console.WriteLine("Çarpma işlemi");
                break;
            case '/':
                Console.WriteLine("Bölme işlemi");
                break;
            case '%':
                Console.WriteLine("Mod alma işlemi");
                break;
            default:
                Console.WriteLine("Geçersiz bir karakter girdiniz");
                break;
        }
    
    }
}

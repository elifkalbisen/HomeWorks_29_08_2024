namespace Soru03;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Birinci sayıyı girin: ");
        if (!double.TryParse(Console.ReadLine(), out double num1))
        {
            Console.WriteLine("Geçerli bir sayı girin.");
            return;
        }

        Console.Write("İkinci sayıyı girin: ");
        if (!double.TryParse(Console.ReadLine(), out double num2))
        {
            Console.WriteLine("Geçerli bir sayı girin.");
            return;
        }

        Console.Write("Bir işlem girin (+, -, *, /): ");
        char operation = Console.ReadKey().KeyChar;
        Console.WriteLine();
        double result;
        switch (operation)
        {
            case '+':
                result = num1 + num2;
                Console.WriteLine($"Sonuç: {num1} + {num2} = {result}");
                break;
            case '-':
                result = num1 - num2;
                Console.WriteLine($"Sonuç: {num1} - {num2} = {result}");
                break;
            case '*':
                result = num1 * num2;
                Console.WriteLine($"Sonuç: {num1} * {num2} = {result}");
                break;
            case '/':
                if (num2 != 0)
                {
                    result = num1 / num2;
                    Console.WriteLine($"Sonuç: {num1} / {num2} = {result}");
                }
                else
                {
                    Console.WriteLine("Bölme hatası: Bir sayıyı sıfıra bölemezsiniz.");
                }
                break;
            default:
                Console.WriteLine("Geçersiz işlem. Lütfen +, -, * veya / girin.");
                break;
        }
    }
}

namespace Soru06;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Bir not girin (A, B, C, D, F): ");
        char not = Char.ToUpper(Console.ReadKey().KeyChar);
        Console.WriteLine();
        
        switch (not)
        {
            case 'A':
            case 'B':
            case 'C':
                Console.WriteLine($"Not: {not} - Geçtiniz.");
                break;
            case 'D':
                Console.WriteLine($"Not: {not} - Geçtiniz, ancak düşük not aldınız.");
                break;
            case 'F':
                Console.WriteLine($"Not: {not} - Kaldınız.");
                break;
            default:
                Console.WriteLine("Geçerli bir not girin (A, B, C, D, F).");
                break;
        }
    }
}

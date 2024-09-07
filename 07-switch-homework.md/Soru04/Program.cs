namespace Soru04;

class Program
{
    static void Main(string[] args)
    {
        
        Console.Write("Bir harf girin: ");
        char input = Char.ToLower(Console.ReadKey().KeyChar);
        Console.WriteLine();

        if (Char.IsLetter(input))
        {
            
            switch (input)
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                case 'ö':
                case 'ü':
                    Console.WriteLine($"{input} sesli bir harftir.");
                    break;
                default:
                    Console.WriteLine($"{input} sessiz bir harftir.");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Geçerli bir harf girin.");
        }
    }
}

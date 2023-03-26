class Program
{
    private const string Vazio = "";

    private static void Main(string[] args)
    {
        System.ConsoleColor CorFundoOriginal = Console.BackgroundColor;
        System.ConsoleColor CorFonteOriginal = Console.ForegroundColor;
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.White;
        Console.BackgroundColor = ConsoleColor.Blue;
        Console.Clear();
        Console.WriteLine("#########################################################################################");
        Console.WriteLine("###################            OPERAÇÕES VERSÃO 1.0            ##########################");
        Console.WriteLine("#########################################################################################");
        Console.WriteLine('\n');

        Console.Write("Informe o primeiro número: ");

        string input = "";
        int numero1;
        int numero2;

        input = Console.ReadLine()!;

        if (input != Vazio)
        {
            numero1 = int.Parse(input);
        } else {
            numero1 = 0;
        }

        
        Console.Write("Informe o segundo número: ");
        
        input = "";
        input = Console.ReadLine()!;

        if (input != Vazio){
            numero2 = int.Parse(input);
        } else {
            numero2 = 1; //Coloquei 1 para evitar divisão por 0 caso usuário não informe número
        }

        Console.WriteLine("\n Resultado das operações");
        Console.WriteLine("#########################################################################################");

        Console.WriteLine(" {0}  +  {1} = {2} ", numero1, numero2, numero1 + numero2);
        Console.WriteLine(" {0}  -  {1} = {2} ", numero1, numero2, numero1 - numero2);
        Console.WriteLine(" {0}  *  {1} = {2} ", numero1, numero2, numero1 * numero2);
        Console.WriteLine(" {0}  /  {1} = {2} ", numero1, numero2, numero1 / numero2);
        Console.WriteLine(" {0} mod {1} = {2} ", numero1, numero2, numero1 % numero2);

        Console.ReadKey();

        Console.BackgroundColor = CorFundoOriginal;
        Console.ForegroundColor = CorFonteOriginal;

        Console.Clear();
    }
}
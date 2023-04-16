using static System.Console;

class Program
{
    public static void Main(string[] args)
    {
        WriteLine(Teste);
        Write("\n Digite um número qualquer: ");
        int num = int.Parse(GetValue(ReadLine()));
        
        WriteLine(Teste2(num));
        ReadKey();        
    }

    private static string GetValue(string? s) => s == null || s == string.Empty ? "0" : s;
    private static string Teste2(int n) => (n % 2 == 0) ? "É Par" : "É Impar";
    private static string Teste => "Olá usuário";
}
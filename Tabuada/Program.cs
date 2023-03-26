class Program
{
    private const String Vazio = "";
   private static void Main(string[] args){
    
    System.ConsoleColor CorFundo = Console.BackgroundColor;
    System.ConsoleColor CorFonte = Console.ForegroundColor;

    Console.BackgroundColor = ConsoleColor.DarkGreen;
    Console.ForegroundColor = ConsoleColor.Red;

    while (true){
        Console.Clear();
        Cabecalho(); 
        Console.WriteLine("Informe um número que gostaria de verificar a tabuada ou digite EXIT para sair:");
        String input = Vazio;

        input = Console.ReadLine()!;
        
        if (input == Vazio){
            continue;
        }

        if (input == "EXIT" || (input == "exit")){
            break;
        }

        int numero = int.Parse(input);

        Console.WriteLine("\n Tabuada do {0}:", numero);
        Console.WriteLine("------------------------------------------------------------------------------");

        for (int Multiplicador = 0; Multiplicador <= 10; Multiplicador++)
            Console.WriteLine(" {0} x {1} = {2} ", numero, Multiplicador, numero * Multiplicador);

        Console.WriteLine("\n Aperte qualquer tecla para Prosseguir");
        Console.ReadKey();    
    }

    Console.WriteLine("Pressione qualquer tecla para limpar a tela");
    Console.ReadKey();

    Console.BackgroundColor = CorFundo;
    Console.ForegroundColor = CorFonte;

    Console.Clear();

   }

   public static void Cabecalho(){
    Console.WriteLine("#######################################################################################");
    Console.WriteLine("##################                                        #############################");
    Console.WriteLine("##################           TABUADA versão 1.0           #############################");
    Console.WriteLine("##################                                        #############################");
    Console.WriteLine("#######################################################################################");
    Console.WriteLine('\n');
   }
}

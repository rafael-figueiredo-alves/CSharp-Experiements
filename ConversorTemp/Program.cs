class Program
{
    public const String Vazio = "";
    private static void Main(String[] Args){

     System.ConsoleColor BackColor = Console.BackgroundColor;
     System.ConsoleColor FontColor = Console.ForegroundColor;

     Console.BackgroundColor = ConsoleColor.Cyan;
     Console.ForegroundColor = ConsoleColor.Gray;

     Console.Clear();

     while (true){
        Console.Clear();
        Cabecalho(); 
        Console.WriteLine("Informe a temperatura em Celsius que gostaria de converter em Fahrenheit e em Kelvin ou digite EXIT para sair:");
        String input = Vazio;

        input = Console.ReadLine()!;
        
        if (input == Vazio){
            continue;
        }

        if (input == "EXIT" || (input == "exit")){
            break;
        }

        Double Temp = Double.Parse(input);

        Double TempF = (Temp * 1.8) + 32;
        Double TempK = Temp + 273;

        Console.WriteLine("\n Resultados:");
        Console.WriteLine("------------------------------------------------------------------------");
        Console.WriteLine("Temperatura em Fahrenheit : {0} ºF", TempF);
        Console.WriteLine("Temperatura em Kelvin     : {0} K", TempK);

        Console.WriteLine("\n Pressione qualquer tecla para executar nova pesquisa");
        Console.ReadKey();
     }

     Console.BackgroundColor = BackColor;
     Console.ForegroundColor = FontColor;

     Console.Clear();

    }

   public static void Cabecalho(){
    Console.WriteLine("#######################################################################################");
    Console.WriteLine("##################                                        #############################");
    Console.WriteLine("##################        Conversor de Temperatura        #############################");
    Console.WriteLine("##################             versão 1.0                 #############################");
    Console.WriteLine("##################                                        #############################");
    Console.WriteLine("#######################################################################################");
    Console.WriteLine('\n');
   }    
}

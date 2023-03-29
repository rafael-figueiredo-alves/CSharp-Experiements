class Program
{
interface Teste
{
    public string Mostrar();
}

class cTeste : Teste
{
    public string Mostrar(){
        Console.WriteLine("Classe Teste");
        return "Meu novo teste";
    }

    public static Teste Nova(){
      return new cTeste();
    }
}

public static void Main(string[] Args){
  string oTeste = cTeste.Nova().Mostrar();
  Console.WriteLine(oTeste);
  
}
}



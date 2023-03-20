Console.Clear();
Console.WriteLine("###########################################################");
Console.WriteLine("#########      Cálculo de IMC versão 1.0        ###########");
Console.WriteLine("###########################################################");
Console.WriteLine("");

float peso;
float Altura;
float IMC;

Console.WriteLine("Informe seu Peso: ");
peso = float.Parse(Console.ReadLine()!);

Console.WriteLine("Informe sua Altura: ");
Altura = float.Parse(Console.ReadLine()!);

IMC = peso / (Altura * Altura);

if (IMC >= 40){
    Console.WriteLine("Obesidade III (mórbida)");
    Console.ReadKey();
    Console.Clear();
} else if (IMC >= 35 && IMC < 40){
    Console.WriteLine("Obesidade II (severa)");
    Console.ReadKey();
    Console.Clear();    
} else if (IMC >= 30 && IMC < 35){
    Console.WriteLine("Obesidade I");
    Console.ReadKey();
    Console.Clear();     
} else if (IMC >= 25 && IMC < 30){
    Console.WriteLine("Acima do peso");
    Console.ReadKey();
    Console.Clear(); 
} else if (IMC >= 18.5 && IMC < 25){
    Console.WriteLine("Peso normal");
    Console.ReadKey();
    Console.Clear(); 
} else if (IMC >= 17 && IMC < 18.5){
    Console.WriteLine("Abaixo do peso");
    Console.ReadKey();
    Console.Clear();     
} else if (IMC < 17){
    Console.WriteLine("Muito abaixo do peso");
    Console.ReadKey();
    Console.Clear();    
}


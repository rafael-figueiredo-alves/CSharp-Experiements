// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int a = 5;
int b = 6;

if ((a == 4) || (b == 6)){
    Console.WriteLine("Verdadeiro em ambos");
} else {
    Console.WriteLine("Falso no primeiro");
}


if ((a == 4) | (b == 6)){
    Console.WriteLine("Verdadeiro em 1 dos termos");
} else {
    Console.WriteLine("Falso nos dois termos");
}

Console.ReadKey();

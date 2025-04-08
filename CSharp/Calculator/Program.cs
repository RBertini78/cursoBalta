using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;

class Program
{

    static void Main(string[] args)
    {
        Menu();
    }

    static void Menu()
    {
        Console.Clear();
        Console.WriteLine("O que deseja fazer?");
        Console.WriteLine("1 - Soma");
        Console.WriteLine("2 - Subtração");
        Console.WriteLine("3 - Divisão");
        Console.WriteLine("4 - Multiplicação");
        Console.WriteLine("5 - Sair");

        Console.WriteLine("Selecione uma opção: ");
        short res = short.Parse(Console.ReadLine());

        switch (res)
        {
            case 1: Soma(); break;
            case 2: Subtracao(); break;
            case 3: Divisao(); break;
            case 4: Multiplicacao(); break;
            case 5: System.Environment.Exit(0); break;
            default: Menu(); break;
        }
    }
     static void Soma()
    {
        Console.Clear();
        Console.WriteLine("Primeiro valor: ");
        float valor1 = float.Parse(Console.ReadLine());
        Console.WriteLine("Segundo valor: ");
        float valor2 = float.Parse(Console.ReadLine());

        float resultado = valor1 + valor2;
        Console.WriteLine($"Resultado: {resultado}");
        Console.ReadKey();
        Menu();
    }

    static void Subtracao()    
    {
        Console.Clear();
        Console.WriteLine("Primeiro valor: ");
        float valor1 = float.Parse(Console.ReadLine());
        Console.WriteLine("Segundo valor: ");
        float valor2 = float.Parse(Console.ReadLine());

        float resultado = valor1 - valor2;
        Console.WriteLine($"Resultado: {resultado}");
        Console.ReadKey();
        Menu();
    }

    static void Divisao()
    {
        Console.Clear();
        Console.WriteLine("Primeiro valor: ");
        float valor1 = float.Parse(Console.ReadLine());
        Console.WriteLine("Segundo valor: ");
        float valor2 = float.Parse(Console.ReadLine());

        float resultado = valor1 / valor2;
        Console.WriteLine($"Resultado: {resultado}");
        Console.ReadKey();
        Menu();
    }

    static void Multiplicacao()
    {
        Console.Clear();
        Console.WriteLine("Primeiro valor: ");
        float valor1 = float.Parse(Console.ReadLine());
        Console.WriteLine("Segundo valor: ");
        float valor2 = float.Parse(Console.ReadLine());

        float resultado = valor1 * valor2;
        Console.WriteLine($"Resultado: {resultado}");
        Console.ReadKey();
        Menu();
    }
}

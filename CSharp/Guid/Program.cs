using System.Text;

namespace TesteGuid;

class Program
{
    static void Main(string[] args)
    {
        var id = Guid.NewGuid();
        Console.WriteLine(id);

        var texto = "Este é um texto de teste";
        Console.WriteLine(texto.ToLower());
        Console.WriteLine(texto.ToUpper());
        Console.WriteLine(texto.Length);
        Console.WriteLine(texto.Insert(5, "AQUI "));
        Console.WriteLine(texto.Remove(5, 5));
        Console.WriteLine(texto.Replace("teste", "exemplo"));

        var resultado = texto.Split(" ");
        Console.WriteLine(resultado[0]);
        Console.WriteLine(resultado[1]);
        Console.WriteLine(resultado[2]);
        Console.WriteLine(resultado[3]);
        Console.WriteLine(resultado[4]);

        var resultado2 = texto.Substring(5, 5);
        Console.WriteLine(resultado2);

        var texto2 = new StringBuilder();
        texto2.Append("Este é um texto de teste");
        texto2.Append(" e este é um segundo texto");
        Console.WriteLine(texto2.ToString());
    }
}

namespace Arrays;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        var meuArray = new int[5]; // Array de inteiros de 5 posições
        int [] meuArray2 = new int[5]{1, 2, 31 ,22,27}; // Outra forma de declarar um array de inteiros de 5 posições

        // meuArray[0] = 10;

        // Console.WriteLine(meuArray[0]);
        // Console.WriteLine(meuArray2[0]);
        // Console.WriteLine(meuArray2[1]);
        // Console.WriteLine(meuArray2[2]);
        // Console.WriteLine(meuArray2[3]);
        // Console.WriteLine(meuArray2[4]);

        // 
        // for (var index = 0; index < meuArray2.Length; index++)
        // {
        //     Console.WriteLine(meuArray2[index]);
        // }

        foreach (var item in meuArray2)
        {
            Console.WriteLine(item);
        }
        
    }
}

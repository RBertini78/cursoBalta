using System;
using System.Security.Cryptography;

namespace NovoProjeto;



class Program
{
    static void Main(string[] args)
    {
        // var texto = "Testando";
        // int idade = 27;

        // Console.WriteLine(idade);
        // Console.Write(texto);
        // Console.WriteLine("Generating invoices for customer \"Contoso Corp\" ... \n");
        // Console.WriteLine("Invoice: 1021\t\tComplete!");
        // Console.WriteLine("Invoice: 1022\t\tComplete!");
        // Console.WriteLine("\nOutput Directory:\t");
        // Console.Write(@"c:\invoices");
        // // To generate Japanese invoices:
        // // Nihon no seikyū-sho o seisei suru ni wa:
        // Console.Write("\n\n\u65e5\u672c\u306e\u8acb\u6c42\u66f8\u3092\u751f\u6210\u3059\u308b\u306b\u306f\uff1a\n\t");
        // // User command to run an application
        // Console.WriteLine(@"c:\invoices\app.exe -j");

        // // string firstName = "Bob";
        // // string message = $"Hello {firstName}!";
        // // Console.WriteLine(message);

        // // int version = 11;
        // // string updateText = "Update to Windows";
        // // string message = $"{updateText} {version}";
        // // Console.WriteLine(message);

        // int version = 11;
        // string updateText = "Update to Windows";
        // Console.WriteLine($"{updateText} {version}!");

        // string projectName = "First-Project";
        // Console.WriteLine($@"C:\Output\{projectName}\Data");

        // string projectName = "ACME";

        // string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";

        // Console.WriteLine("View English output:");
        // Console.Write($@"c:\Exercise\{projectName}\data.txt");
        // Console.WriteLine("\n" + russianMessage);
        // Console.Write($@"c:\Exercise\{projectName}\ru-RU\data.txt");

        // string projectName = "ACME";
        // string englishLocation = $@"c:\Exercise\{projectName}\data.txt";
        // Console.WriteLine($"View English output:\n\t\t{englishLocation}\n");

        // string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";
        // string russianLocation = $@"c:\Exercise\{projectName}\ru-RU\data.txt";
        // Console.WriteLine($"{russianMessage}:\n\t\t{russianLocation}\n");

        // int fahrenheit = 94;
        // float temperatura = (fahrenheit - 32) * 5 / 9;
        // Console.WriteLine($"A temperatura é {temperatura}° Celsius");

        // 

        // int inteiro = 100;
        // float real = 25.3f;

        // real = inteiro;
        // inteiro = (int)real;
        // inteiro = int.Parse(real.ToString());
        // string valorReal = real.ToString();
        // inteiro = int.Parse(valorReal);
        // inteiro = Convert.ToInt32(real);
        // Console.WriteLine(inteiro);
        // var dolar = 6.40;
        // Product mouse = new Product(1, "Mouse", 20.00, ECategories.Eletronics);
        // var livro = new Product(2, "Livro", 30.00, ECategories.Books);
        // Console.WriteLine(mouse.PrinceInDolar(dolar));
        // 

        // string[] fraudulentOrderIDs = new string[3];
        // fraudulentOrderIDs[0] = "A123";
        // fraudulentOrderIDs[1] = "B456";
        // fraudulentOrderIDs[2] = "C789";
        // Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
        // Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
        // Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

        // fraudulentOrderIDs[0] = "F000";
        // Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}");

        // Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders to process.");

        // int[] inventory = { 200, 450, 700, 175, 250 };
        // int sum = 0;
        // int bin = 0;
        // foreach (int items in inventory)
        // {
        //     sum += items;
        //     bin++;
        //     Console.WriteLine($"Bin {bin} = {items} items (Running total: {sum})");
        // }
        // Console.WriteLine($"We have {sum} items in inventory.");
        string[] freudulentOrderID = { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" };

        foreach (string order in freudulentOrderID)
        {
            if (order.StartsWith("B"))
            {
                Console.WriteLine(order);
            }
        }

        Random random = new Random();
        string[] orderIDs = new string[5];
        // Loop through each blank orderID
        for (int i = 0; i < orderIDs.Length; i++)
        {
            // Get a random value that equates to ASCII letters A through E
            int prefixValue = random.Next(65, 70);
            // Convert the random value into a char, then a string
            string prefix = Convert.ToChar(prefixValue).ToString();
            // Create a random number, pad with zeroes
            string suffix = random.Next(1, 1000).ToString("000");
            // Combine the prefix and suffix together, then assign to current OrderID
            orderIDs[i] = prefix + suffix;
        }
        // Print out each orderID
        foreach (var orderID in orderIDs)
        {
            Console.WriteLine(orderID);
        }
    }
}

// struct Product
// {
//     public Product(int id, string name, double price, ECategories category)
//     {
//         Id = id;
//         Name = name;
//         Price = price;
//         Category = category;
//     }
//     public int Id;
//     public string Name;
//     public double Price;
//     public ECategories Category;

//     public double PrinceInDolar(double dolar)
//     {        
//         return Price * dolar;
//     }
// }

// enum ECategories
// {
//     Eletronics = 1,
//     Clothing = 2,
//     Books = 3
// }

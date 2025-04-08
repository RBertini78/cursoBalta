using System.Runtime.CompilerServices;

namespace Delegates;

class Program
{
    static void MakePayment(double ammount)
    {
        Console.WriteLine($"Payment of {ammount} has been made");
    }
    static void Main(string[] args)
    {
        //delagates ou Anonymous Methods
        var pay = new Payment.Pay(MakePayment);
        pay(1000);
        //Anonymous Methods
        Payment.Pay pay2 = delegate (double ammount)
        {
            Console.WriteLine($"Payment of {ammount} has been made");
        };
        pay2(2000);
        //Lambda Expressions
        Payment.Pay pay3 = (double ammount) =>
        {
            Console.WriteLine($"Payment of {ammount} has been made");
        };
        pay3(3000);
        //Lambda Expressions
        Payment.Pay pay4 = (ammount) =>
        {
            Console.WriteLine($"Payment of {ammount} has been made");
        };
        pay4(4000);
        //Lambda Expressions
        Payment.Pay pay5 = ammount =>
        {
            Console.WriteLine($"Payment of {ammount} has been made");
        };
        pay5(5000);
        //Lambda Expressions
        Payment.Pay pay6 = ammount => Console.WriteLine($"Payment of {ammount} has been made");
        pay6(6000);
    }

    public class Payment
    {
        public delegate void Pay(double ammount);
    }
}

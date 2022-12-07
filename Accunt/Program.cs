// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System.Collections;
using System.Linq;

Account.remaning();
public class Account
{
    public static async Task<int> deposit()
    {
        Console.WriteLine("please inter your deposite amount");
        int Depositeamount = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("your balance is :" + Depositeamount);
        return Depositeamount;
    }

    public static async Task<int> widraw()
    {
        Console.WriteLine("please inter your widraw amount");
        int Widrawamount = Convert.ToInt32(Console.ReadLine());
        return Widrawamount;
    }

    public static async Task<int> remaning()
    {
        var a = deposit().Result;
        var b = widraw().Result;
        var c = a - b;
        var h = await ListOfDucuments();
        if (a >= b)
        {
            Console.WriteLine("your opration is done");
            Console.WriteLine($"your balance is {c}");
            foreach (var d in h)
                Console.WriteLine(d);       
           
        }
        else
        {
            Console.WriteLine("your opration faild \t amout of widraw must be lowear than the deposit amount");
           // throw new Exception (); 
        }
        return c ;
    }
    public static Task< List<string>> ListOfDucuments()
    {
        var p = new List<string> {"bill","profile"};

        return Task.FromResult(p)  ;
       
    }

}

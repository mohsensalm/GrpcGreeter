// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Account.remaning();
public class Account
{
   // public IList duc { get; set; }
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
        if (a >= b)
        {
            Console.WriteLine("your opration is done");
            Console.WriteLine(c);
        }
        else
        {
            Console.WriteLine("your opration faild \t amout of widraw must be lowear than the deposit mount");
           // throw new Exception (); 

        }
        return c;


    }

}

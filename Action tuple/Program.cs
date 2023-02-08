using System;
namespace Actiontuple
{

    class program
    {
        static void Main(string[] args)
        {
            
            Action<(int,string,string)>s=(x)=>Console.WriteLine($"Id = {x.Item1},\nFirst name = {x.Item2},\nLast name = {x.Item3}");
            System.Console.WriteLine("Enter your id");
            int id=Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Enter your first name");
            string name=Console.ReadLine()!;
            System.Console.WriteLine("Enter your last name");
            string lname=Console.ReadLine()!;
            s((id,name,lname));
            

        }

        
    }
}
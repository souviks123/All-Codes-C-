using System;
namespace Tuple{
    class Program{
        static void Main(string[] args)
        {
            Func<(int,int,int),(int,int,int)> Double=(x)=>(x.Item1*2,x.Item2*2,x.Item3*2);
            System.Console.WriteLine(Double((1,2,3)));
            
            Func<(int,int,int),(int,int,int)> cube=(x)=>(x.Item1*x.Item1*x.Item1,x.Item2*x.Item2*x.Item2,x.Item3*x.Item3*x.Item3);
            System.Console.WriteLine(cube((4,5,6)));

        }
    }
}
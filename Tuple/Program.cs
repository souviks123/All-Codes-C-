using System;
namespace Example{
    
    class Program{
        public static int method(int num)
    {
        return num + num;
    }
        static void ConsolePrint(int i)
{
    Console.WriteLine(i);
}
        static void Main(string[] args)
        {
            Func<int,int,bool> check=(x,y)=>x>y;
            System.Console.WriteLine(check(5,4));

            Action<int,int> check1=(x,y)=>System.Console.WriteLine(x>y);
            check1(1,2);
            
            Func<(int,int),(int,int),(int,int)> s=(x,y)=>(x.Item1*x.Item2,y.Item1*y.Item2);

            System.Console.WriteLine(s((2,2),(3,3)));

            var s3=new Tuple<int,int,string>(1,2,"S");
            System.Console.WriteLine(s3);

            var a1=new Tuple<int,int,int>(1,2,3);
            var a2=new Tuple<int,int,int>(5,6,7);
            var sum=new Tuple<int,int,int>(a1.Item1+a2.Item1,a1.Item2+a2.Item2,a1.Item3+a2.Item3);
            System.Console.WriteLine(sum);

            Action<int> printActionDel = ConsolePrint;
            printActionDel(10);

            Func<int, int> myfun = method;
            Console.WriteLine(myfun(10));

            
        }
        
    }
}
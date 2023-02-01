using System;
using System.Collections.Generic;
namespace Dictionary{
    class Program{
        static void Main(string[] args)
        {
            string p;
            Dictionary<string,int> dict=new Dictionary<string, int>();
            do{
            System.Console.WriteLine("Enter the no of inputs");
            int a=int.Parse(Console.ReadLine()!);
            for(int i=0;i<a;i++){
                System.Console.WriteLine("Enter the key");
                string s=Console.ReadLine()!;
                System.Console.WriteLine("Enter the values");
                int s1=int.Parse(Console.ReadLine()!);
                dict.Add(s,s1);
            }
            System.Console.WriteLine("--------------------------------------------------");
            foreach(var j in dict.Keys){
                System.Console.WriteLine($"Key: {j} and Values: {dict[j]}");
            }
            /*
            System.Console.WriteLine("Enter value to get key");
            int w=int.Parse(Console.ReadLine()!);
            string result = dict.Keys.FirstOrDefault(s => dict[s] ==w)!;
            System.Console.WriteLine(result);*/
            System.Console.WriteLine("Enter 0 to re-entry or else to exit");
            p=Console.ReadLine()!;
            }while(p=="0");
        }
    }
}

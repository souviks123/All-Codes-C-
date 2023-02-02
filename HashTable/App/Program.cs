using System;
using System.Collections;

namespace App
{
    class Program 
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            string p;
            do{
            System.Console.WriteLine("Enter no of key-value pair you want to store");
            int b=int.Parse(Console.ReadLine()!);
            for(int i=0;i<b;i++){
                System.Console.WriteLine("Enter the Key");
                var s=Console.ReadLine();
                System.Console.WriteLine("Enter the value of the key");
                var a=Console.ReadLine();
                ht.Add(s,a);
            }
            System.Console.WriteLine("--------------------------------");
            
            foreach(var j in ht.Keys){
                System.Console.WriteLine($"Keys: {j} and Values: {ht[j]}");                

            }
            System.Console.WriteLine("Enter o to try again or else to exit");
            p=Console.ReadLine()!;
            }while(p=="0");
            

        }
    }
}
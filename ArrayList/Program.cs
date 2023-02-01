using System;
using System.Collections;

namespace Arraylist
{
    class Program
    {
        static void Main(string[] args)
        {
            
            ArrayList arr = new ArrayList();
            string p;
            do{
                System.Console.WriteLine("Enter no of elements you want to add");
                int d=int.Parse(Console.ReadLine()!
                );
                for(int i=0;i<d;i++){
                    System.Console.WriteLine("Enter the no to add in the array");
                    int g=int.Parse(Console.ReadLine()!);
                    arr.Add(g);
                }
                foreach(var j in arr){
                    System.Console.WriteLine($"The elements are: {j}");
                }
                System.Console.WriteLine("Enter 0 to continue or else to exit");
                p=Console.ReadLine()!;

            }while(p=="0");
        }
    }
}


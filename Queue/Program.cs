using System;
using System.Collections;

namespace Q{
    class test{
        static void Main(string[] args)
        
        {
            Queue mq=new Queue();
            string p;
            do{
            System.Console.WriteLine("Enter no of inputs");
            int s=int.Parse(Console.ReadLine()!);
            for(int i=0;i<s;i++){
                System.Console.WriteLine("Enter the elements");
                string e=Console.ReadLine()!;
                mq.Enqueue(e);
            }
            System.Console.WriteLine("---------------------");
            System.Console.WriteLine("The queue elements");
            foreach(object item in mq){
                System.Console.Write(item+"  ");
            }
            System.Console.WriteLine();
            System.Console.WriteLine("Enter 0 to continue else to exit");
            p=Console.ReadLine()!;

        }while(p=="0");
        }
    }
}
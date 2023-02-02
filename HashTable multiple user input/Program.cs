using System;
using System.Collections;
namespace hash{
    class Test{
        static void Main(string[] args)
        {
            Hashtable h1=new Hashtable();
            while(true){
                System.Console.WriteLine("Enter key or 00 to exit ");
                var s=Console.ReadLine()!;
                if(s=="00"){
                    break;
                }else{
                    System.Console.WriteLine("Enter value");
                    var p=Console.ReadLine();
                    h1.Add(s,p);
                }


            }
            System.Console.WriteLine("-----------------------------------");
            foreach(DictionaryEntry i in h1){
                System.Console.WriteLine($"The key: {i.Key} and the value: {i.Value}");
            }
            System.Console.WriteLine("Thank you");
        }
    }
}
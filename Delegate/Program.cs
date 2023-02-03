using System;
using ClassLibrary;
namespace DelegateExamples{
    class Program{
        static void Main(string[] args)
        {
            Sample s=new Sample();
            MyDelegateType myDelegate;
            myDelegate=new MyDelegateType(s.Add);
            System.Console.WriteLine(myDelegate.Invoke(30,40));   
        }
    }
}
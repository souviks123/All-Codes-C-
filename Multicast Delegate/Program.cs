using System;
using ClassLibrary;
namespace multicast{
    class Program{
        static void Main(string[] args)
        {
            sample s=new sample();
            MyDelegateType myDelegate;
            myDelegate=new MyDelegateType(s.add);
            myDelegate+=s.Multiply;
            myDelegate+=s.Substract;
            myDelegate.Invoke(40,10);
            myDelegate-=s.Substract;
            myDelegate.Invoke(40,10);
        }
    }
}

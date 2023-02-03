using System;

public delegate void MyHandler(object sender, MyEventArgs e);
class A
{
    
    
    public void OnHandler(object sender, MyEventArgs e)
    {
        Console.WriteLine("I am in Office and my name is {0}", e.name);
    }
    
    
    public A(B b)
    {
        MyHandler d1 = new MyHandler(OnHandler);
        
        b.Event += d1;

        
    }
}

class B
{
    public event MyHandler? Event;
   
    public void FireEvent(MyEventArgs e)
    {
        if (Event != null)
        {
            Event(this, e);
        }
        
    }
    
}
public class MyEventArgs : EventArgs
{
    
    public string name=Console.ReadLine()!;
}
public class Driver
{
    public static void Main()
    {
        B b = new B();
        A a = new A(b);
        MyEventArgs e1 = new MyEventArgs();
        
       
        // e1.name= "My name is ";
        
        b.FireEvent(e1);
        
    }
}
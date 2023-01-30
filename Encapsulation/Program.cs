using System;
namespace Structures{
    class Circle{
    public double radius;
    public double GetArea(){
        return 3.14*radius*radius;
    }
    public void Display(){
        System.Console.WriteLine("The radius of the circle is: "+radius+" unit");
        System.Console.WriteLine("The Area is: "+GetArea()+" unit square");
        System.Console.WriteLine("Thank you");
    }
}
class ExecuteCircle{
    static void Main(string[] args){
        Circle c=new Circle();
        c.radius=5.6;
        c.Display();
        Console.ReadLine();
    }
}
}
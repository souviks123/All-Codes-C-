/*
public abstract class House{
    public abstract void room();
}
public class Floor:House{
    public override void room(){
        System.Console.WriteLine("Ground Floor");
    }
}
public class Floor2:House{
    public override void room(){
        System.Console.WriteLine("1st Floor");
    }
}
public class main_method{
    public static void Main(){
        House h;
        h=new Floor();
        h.room();
        h=new Floor2();
        h.room();
    }
}
*/

abstract class AreaClass{
    abstract public int Area();
}
class Square:AreaClass{
    int side=0;
    public Square(int n){
        side=n;
    }
    public override int Area(){
        return side*side;
    }
}
class Test{
    public static void Main(){
        Square s=new Square(6);
        System.Console.WriteLine("Area = "+s.Area());
    }
}

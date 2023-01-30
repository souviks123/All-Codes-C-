using System;
namespace SealedDemo{
public class Student{
protected int S_id,S_age;
protected string S_Name,S_Address;
public virtual void GetStudentData(){
System.Console.WriteLine("Enter Student details");
System.Console.Write("Enter Student ID: ");
S_id=int.Parse(Console.ReadLine());
System.Console.Write("Enter Student name: ");
S_Name=Console.ReadLine();
System.Console.Write("Enter Student address: ");
S_Address=Console.ReadLine();
System.Console.Write("Enter Student age: ");
S_age=int.Parse(Console.ReadLine());
}
public virtual void DisplayStudentData(){
    Console.WriteLine("\nStudent Details Are:");
    Console.WriteLine($"Student ID: {S_id}");
    Console.WriteLine($"Student Name: {S_Name}");
    Console.WriteLine($"Student Address: {S_Address}");
    Console.WriteLine($"Student Age: {S_age}");
}
}
public sealed class Marks:Student{
    double mark;
    string grade;
    public override void GetStudentData(){
        System.Console.WriteLine("Enter Marks details");
        System.Console.Write("Enter Student Id: ");
        S_id=int.Parse(Console.ReadLine());
        Console.Write("Enter Student Name: ");
        S_Name = Console.ReadLine();
        Console.Write("Enter Student marks: ");
        mark = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter Student grade: ");
        grade = Console.ReadLine();
    }
    public override void DisplayStudentData()
        {
            Console.WriteLine("\nStudent Details Are:");
            Console.WriteLine($"Student ID: {S_id}");
            Console.WriteLine($"Student Name: {S_Name}");
            Console.WriteLine($"Student Marks: {mark}");
            Console.WriteLine($"Student grade: {grade}");
        }
}
    class Program
    {
        static void Main(string[] args)
        {
            Marks m1 = new Marks();
            m1.GetStudentData();
            m1.DisplayStudentData();
            Console.ReadKey();
          
}
}
}

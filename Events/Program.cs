using System;

using System; 
namespace EventDemo{
    class Program{
        static void Main(string[] args)
        {
            EmployeeSeparator employeeSeparator=new EmployeeSeparator();
            Finance finance=new Finance(employeeSeparator);
            IT it=new IT(employeeSeparator);
            employeeSeparator.Separate();
        }
    }
}

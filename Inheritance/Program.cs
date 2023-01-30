// See https://aka.ms/new-console-template for more information
namespace InheritanceExample{
    class Program{
        static void Main(string[] args){
            Employee emp1=new Employee();
            emp1.EmpID=101;
            emp1.Empname = "Souvik";
            emp1.Location="Kolkata";
            System.Console.WriteLine("Object of Parent class (Employee):");
            System.Console.WriteLine(emp1.EmpID);
            System.Console.WriteLine(emp1.Empname);
            System.Console.WriteLine(emp1.Location);
            System.Console.WriteLine();

            Manager mgr1=new Manager();
            mgr1.EmpID=101;
            mgr1.Empname = "Mandal";
            mgr1.Location="Kolkata";
            mgr1.DepartmentName="Sales";
            System.Console.WriteLine("Object of Parent class (Manager):");
            System.Console.WriteLine(mgr1.EmpID);
            System.Console.WriteLine(mgr1.Empname);
            System.Console.WriteLine(mgr1.Location);
            System.Console.WriteLine(mgr1.DepartmentName);
            System.Console.WriteLine(mgr1.GetTotalSalesOfTheYear());
            System.Console.WriteLine();

            SalesMan sm1=new SalesMan();
            sm1.EmpID=103;
            sm1.Empname = "John";
            sm1.Location="Kolkata";
            sm1.Region="Hindu";
            System.Console.WriteLine("Object of Parent class (SalesMan):");
            System.Console.WriteLine(sm1.EmpID);
            System.Console.WriteLine(sm1.Empname);
            System.Console.WriteLine(sm1.Region);
            System.Console.WriteLine(sm1.GetSalesOfTheCurrentMonth());
            System.Console.WriteLine();
        }
    }
}

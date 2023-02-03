using System; 
namespace EventDemo{
    class Finance{
        public readonly EmployeeSeparator employeeSeparator;
        public Finance(EmployeeSeparator employeeSeparator){
            this.employeeSeparator=employeeSeparator;
            employeeSeparator.EmployeeSeparated +=EmployeeSeparatedEventHandler!;

        }
        public void EmployeeSeparatedEventHandler(object sender,EmployeeEventArgs e){
            System.Console.WriteLine("Finance Department: Employee Separation Process: "+e.Name);
        }
    }
}

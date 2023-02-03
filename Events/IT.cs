using System; 
namespace EventDemo{
    class IT{
        private readonly EmployeeSeparator employeeSeparator;
        public IT(EmployeeSeparator employeeSeparator){
            this.employeeSeparator=employeeSeparator;
            employeeSeparator.EmployeeSeparated+= EmployeeSeparatedEventHandler!;
        }
        public void EmployeeSeparatedEventHandler(object sender,EmployeeEventArgs e){
            System.Console.WriteLine("IT Department: Employee Separation Process: "+e.Name);
        }
    }
}

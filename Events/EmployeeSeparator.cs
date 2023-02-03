using System; 
namespace EventDemo{
    class EmployeeEventArgs:EventArgs{
        public int EmpId{get;set;}
        public string? Name{get;set;}

    }
    class EmployeeSeparator{
        // public delegate void EmployeeSeparatedEventHandler();
        public event EventHandler<EmployeeEventArgs>? EmployeeSeparated;
        public void Separate(){
            EmployeeEventArgs employeeEventArgs=new EmployeeEventArgs{EmpId=123,Name="Souvik"};
            if(EmployeeSeparated!=null)
            EmployeeSeparated(this,employeeEventArgs);
    }
    }
    
}

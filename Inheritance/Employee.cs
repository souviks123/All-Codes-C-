public class Employee{
    private int _empID;
    private string _empName;
    private string _location;
    public int EmpID{
        set{
            _empID=value;
        }
        get{
            return _empID;
        }
    }
    public string Empname{
        set{
            _empName=value;
        }
        get{
            return _empName;
        }
    }
    public string Location{
        set{
            _location=value;
        }
        get{
            return _location;
        }
    } 
}
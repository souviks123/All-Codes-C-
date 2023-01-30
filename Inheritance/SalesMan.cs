public class SalesMan:Employee{
    private string _region;
    public string Region{
        set{
            _region=value;
        }
        get{
            return _region;
        }
    }

    public long GetSalesOfTheCurrentMonth(){
        return 1000;
    }
}
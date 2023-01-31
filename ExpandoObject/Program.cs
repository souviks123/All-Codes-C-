using System.Dynamic;
namespace Hello{
    class Example{
        public string MyProperty1{get;set;}
        public string MyProperty2{get;set;}
    }
    class Program{
        static void Main(string[] args){
            Example E1=new Example();
            E1.MyProperty1="Val1";
            E1.MyProperty2="Val2";

            System.Console.WriteLine($"Prop1 is : {E1.MyProperty1}");
            System.Console.WriteLine($"Prop2 is : {E1.MyProperty2}");

            dynamic ED=new ExpandoObject();
            ED.prop1="Hello";
            ED.prop2="Hi";
            
            System.Console.WriteLine($"Dynamic property1 is : {ED.prop1}");
            System.Console.WriteLine($"Dynamic property2 is : {ED.prop2}");

            System.Console.Write("Adding properties with dynamic object with IDictionary");
            System.Console.WriteLine("------------------------------------------------------");
            var ED1=new ExpandoObject() as IDictionary<string,object>;
            var anything="One";
            var prop1=$"property{anything}";
            ED1.Add(prop1,"I am prop1 in Dictionary");
            System.Console.WriteLine($"Dynamic prop1 is : {ED1["propertyOne"]}");

        }
    }
}
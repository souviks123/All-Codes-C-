// See https://aka.ms/new-console-template for more information
class Goto{
    static void Main(){
        int i=1;
        System.Console.WriteLine("India");
        System.Console.WriteLine("Australia");
        goto mylabel;
        System.Console.WriteLine("Africa");
        System.Console.WriteLine("US");
        mylabel:
        System.Console.WriteLine("UK");
        System.Console.WriteLine("Bangladesh");

    }
}

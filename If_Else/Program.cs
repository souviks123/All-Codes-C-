// See https://aka.ms/new-console-template for more information
class Program{
    static void Main(string[] args){
        Console.Write("Enter your marks: ");
        int marks=Convert.ToInt32(Console.ReadLine());
        string grade;
        if(marks>=95){
            grade= "AA";
            Console.WriteLine("You passed with good marks");
            Console.WriteLine("Your grade is: "+grade);
        }
        else if(marks>=85){
            grade= "A";
            Console.WriteLine("You passed with good marks");
            Console.WriteLine("Your grade is: "+grade);
        }
        else if(marks>=30){
            grade= "B";
            Console.WriteLine("You passed moderate marks");
            Console.WriteLine("Your grade is: "+grade);
        }
        else{
            grade= "F";
            Console.WriteLine("You failed");
            Console.WriteLine("Your grade is: "+grade);
        }


    }
}

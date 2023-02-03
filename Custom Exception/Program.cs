using System;
namespace CustomException{
    public class WrongNoExeption:Exception{
        public WrongNoExeption():base("Dont allow odd no"){
            System.Console.WriteLine("Try again");
        }
    }
    
    class Program{
        static int GetNo(){
            System.Console.WriteLine("Enter a even no");
            int s=int.Parse(Console.ReadLine()!);
            if(s%2!=0)
                throw new WrongNoExeption();
            return s;    
        }
        static void Main(string[] args)
        {
            int theNo;
            
            try{
                
                theNo=GetNo();
                System.Console.WriteLine("The no no is {0}",theNo);
            }
            catch(WrongNoExeption wr){
                System.Console.WriteLine(wr.Message);
                
            }
            finally{
                System.Console.WriteLine("Have a nice day!");
            }

        }
    }
}
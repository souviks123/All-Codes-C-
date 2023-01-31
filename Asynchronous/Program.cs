namespace Asynchronous{
    internal class Test{
        static void Main(string[] args){
            Task1();
            Task2();
            Task3();
            Console.ReadLine();
        }
        public static async void Task1(){
            await Task.Run(()=>{
                System.Console.WriteLine("Task 1 Starting.."); 
                Thread.Sleep(1000);
                System.Console.WriteLine("Task 1 Completed");
            });
            
        }

        public static async void Task2(){
            await Task.Run(()=>{
                System.Console.WriteLine("Task 2 Starting.."); 
                Thread.Sleep(2000);
                System.Console.WriteLine("Task 2 Completed");
            });
            
        }

        public static async void Task3(){
            await Task.Run(()=>{
                System.Console.WriteLine("Task 3 Starting.."); 
                Thread.Sleep(3000);
                System.Console.WriteLine("Task 3 Completed");
            });
            
        }
    }
}

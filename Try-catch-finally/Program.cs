using System;
class Exception{
    static void Main(string[] args)
    {
        try{
            int[] arr=new int[5]{1,2,3,4,5};
            System.Console.WriteLine("The array is");
            foreach(int j in arr){
                System.Console.Write(j+" ");
            }
            System.Console.WriteLine();
            System.Console.WriteLine("Enter the index no of the array you want to fetch");
            int n=int.Parse(Console.ReadLine()!);
            System.Console.WriteLine($"The element of {n} index in this array is {arr[n-1]}");
        }
        catch(IndexOutOfRangeException){
            System.Console.WriteLine("The size of the array is 5 ");
            System.Console.WriteLine("Index is not present in this array");
        }
        finally{
            System.Console.WriteLine("End of Try-Catch block");
        }
    }
}

using System;
using System.Collections;

class StackDemo {

	
	static public void Main()
	{

		
		Stack my_stack = new Stack();

		
		my_stack.Push("Souvik");
		my_stack.Push("Mandal");
		my_stack.Push('M');
		my_stack.Push(null);
		my_stack.Push(1234);
		my_stack.Push(580);
         

		
		foreach(var elem in my_stack)
		{
			Console.WriteLine(elem);
		}
	}
}

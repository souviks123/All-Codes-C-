
using System;


public class Home {
	
	
	string name = "Ground Floor";

	
	public virtual void showdata()
	{
		Console.WriteLine("Floor Name: " + name);
	}
}


class Member : Home {
	
	
	int s = 10;
	
	
	public override void showdata()
	{
		
		
		base.showdata();
		
		Console.WriteLine("No of members: " + s);
	}
}

class Run {
	
	
	static void Main()
	{
		
		
		Member E = new Member();
		
		
		
		E.showdata();
		
	}
}

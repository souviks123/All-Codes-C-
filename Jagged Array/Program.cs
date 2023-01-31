
using System;

class JaggedArray {
	
	
	public static void Main()
	{
		
		
		int[][] jagged_arr = new int[4][];

		
		jagged_arr[0] = new int[] {1, 2, 3, 4};
		jagged_arr[1] = new int[] {11, 34, 67};
		jagged_arr[2] = new int[] {89, 23};
		jagged_arr[3] = new int[] {0, 45, 78, 53, 99};

		System.Console.WriteLine("Following is the Jagged Array");
		System.Console.WriteLine("------> columns");
		for (int n = 0; n < jagged_arr.Length; n++) {

			
			System.Console.Write("Row({0}): ", n);

			for (int k = 0; k < jagged_arr[n].Length; k++) {

				
				System.Console.Write("{0} ", jagged_arr[n][k]);
			}
			System.Console.WriteLine();
		}
	}
}


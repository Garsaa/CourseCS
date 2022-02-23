using System;
					
public class Program
{
	public static void Main()
	{
	int M, N,i,j;
	int[,] mat;
	M = int.Parse(Console.ReadLine());
	N = int.Parse(Console.ReadLine());
	
	mat = new int[M,N];
	
  for(i=0;i<M;i++){
	  string[] s = Console.ReadLine().Split(' ');
  	for(j=0;j<N;j++){
  		mat[i,j] = int.Parse(s[j]);	  
     }
  }
		
  for(i=0;i<M;i++){
  	for(j=0;j<N;j++){
  		Console.Write(mat[i,j] + " "); 
     }
	  Console.WriteLine();
  }		
		
		
		
		
}
}	
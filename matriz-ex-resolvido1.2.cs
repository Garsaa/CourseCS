using System;
					
public class Program
{
	public static void Main()
	{
		int N, i, j, count = 0;
		int[,] mat;
	
		N = int.Parse(Console.ReadLine());
		
		mat = new int[N,N];
		
		for(i=0;i<N;i++){
		  string[] s = Console.ReadLine().Split(' ');
			for(j=0;j<N;j++){
			 mat[i,j] = int.Parse(s[j]);			
			}			
		}
		
		Console.WriteLine("DIAGONAL PRINCIPAL:");
		for(i=0;i<N;i++){
		  Console.Write(mat[i,i] + " ");	
		}
		Console.WriteLine();
		
		for(i=0;i<N;i++){
			for(j=0;j<N;j++){
			 if(mat[i,j]<0){
				count++; 
			 }
			}			
		}
		Console.WriteLine("QUANTIDADE DE NEGATIVOS = " + count);
		
		
		
		
		
		
		
		
		
}
}	

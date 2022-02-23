using System;
					
public class Program
{
	public static void Main()
	{
		int N, M, i, j, soma;
		int[,] mat;
		int[] vet;
		
		string[] s = Console.ReadLine().Split(' ');
		M = int.Parse(s[0]);
		N = int.Parse(s[1]);
	
		vet = new int[M];
		mat = new int[M,N];
		//lendo a matriz
		for(i=0;i<M;i++){
			string[] q = Console.ReadLine().Split(' ');
			for(j=0;j<N;j++){
			 	mat[i,j] = int.Parse(q[j]);		
			}			
		}
		//gerando o vetor correspondente à soma das linhas da matriz
		for(i=0;i<M;i++){
			for(j=0, soma=0;j<N;j++){
			 	soma+=mat[i,j];				
			}			
		 vet[i]=soma;
		}
		
		for(i=0;i<M;i++){
			Console.WriteLine(vet[i]);
		}
		
}
}	

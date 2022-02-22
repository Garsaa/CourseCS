using System;
					
public class Program
{
	public static void Main()
	{
int N, i;
double[] vet;
		
N = int.Parse(Console.ReadLine());

vet = new double[N];

for(i=0;i<N;i++){
	vet[i] = double.Parse(Console.ReadLine()); 
}		
		
for(i=0;i<N;i++){
	Console.WriteLine(vet[i]);
}		
		
		
	}
}
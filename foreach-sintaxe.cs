using System;
					
public class Program
{
	public static void Main()
	{
	int N;
	string[] nomes;
		
	N = int.Parse(Console.ReadLine());	
	nomes = new string[N];	
	for(int i=0;i<N;i++){
		nomes[i] = Console.ReadLine();
	}
	Console.WriteLine("Nomes lidos: ");
	foreach(string x in nomes){
		Console.WriteLine(x);
	}
		
		
	}
}
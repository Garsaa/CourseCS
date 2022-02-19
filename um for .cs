using System;

public class Program
{
	public static void Main()
	{


int N,i;
N = int.Parse(Console.ReadLine());

if(N<2 || N>1000){
    Console.WriteLine("Valor fora do cálculo!");
}else{
    
    for(i=1;i<=10;i++)
    {
       Console.WriteLine(i+ " x " + N + " = " + i*N);    
        
    }
    
}
    
	
	}				
}

                          
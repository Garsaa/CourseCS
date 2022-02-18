using System;
using System.Globalization;					
public class Program
{
	public static void Main()
	{

 double A,B,C;
 string[] vet1;

       vet1 = Console.ReadLine().Split(' ');


A = double.Parse(vet1[0], CultureInfo.InvariantCulture);
B = double.Parse(vet1[1], CultureInfo.InvariantCulture);	
C = double.Parse(vet1[2], CultureInfo.InvariantCulture);	

if(A==B && A==C)
{
	Console.WriteLine("MENOR = " + A);
}else if(A<B && A<C){
	Console.WriteLine("MENOR = " + A);
}else if(B<A && B<C){
    Console.WriteLine("MENOR = " + B);	
}else{
	  Console.WriteLine("MENOR = " + C);
}
	}	
}

                          
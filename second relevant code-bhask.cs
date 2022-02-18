using System;
using System.Globalization;					
public class Program
{
	public static void Main()
	{

       double A,B,C, delta, R1, R2;
       string[] vet1;

       vet1 = Console.ReadLine().Split(' ');


A = double.Parse(vet1[0], CultureInfo.InvariantCulture);
B = double.Parse(vet1[1], CultureInfo.InvariantCulture);	
C = double.Parse(vet1[2], CultureInfo.InvariantCulture);	

delta = Math.Pow(B,2.0)- 4*A*C;
		
if(delta<0 || A==0){
	Console.WriteLine("IMPOSSÍVEL CALCULAR :p");
}else{
	R1 = (-B+Math.Sqrt(delta))/(2.0*A);
	R2 = (-B-Math.Sqrt(delta))/(2.0*A);

	Console.WriteLine("R1 = "+ R1.ToString("F5"));
	Console.WriteLine("R2 = "+ R2.ToString("F5"));
}	
		
		
		
	}
		
			
		
}

                          
using System;

public class Program
{
	public static void Main()
	{
	int n1 = int.Parse(Console.ReadLine()); //converte o resultado pra int, e lê uma string que depois de convertida é guardada em n1 
	char ch = char.Parse(Console.ReadLine()); //mesmo mas com um cararactére
	while(ch!= 'F' && ch!= 'M' ) //while pra validar o carctére que se refere ao gênero
	{
	  ch = char.Parse(Console.ReadLine());	
	}
	double n2 = double.Parse(Console.ReadLine()); 
	
	
	string[] v1 = Console.ReadLine().Split(' '); //COMANDO SPLIT, usado pra dividir uma string/recortar ela em certas partes que são
	string nome = v1[0];                         //determinadas pelo uso do caractére entre parênteses e então guardado nas posições dos vetores
	char sexo = char.Parse(v1[1]);               //eu atribuindo e convertendo ao mesmo tempo, as posições dos vetores que me interessam, às variáveis que eu quero
	int idade = int.Parse(v1[2]);                
	double altura = double.Parse(v1[3]);
		
	Console.WriteLine(nome);                    //exibindo os dados coletados :p 
	Console.WriteLine(sexo);
	Console.WriteLine(idade);
	Console.WriteLine(altura);
	
	Console.WriteLine(n1);
	Console.WriteLine(ch);
	Console.WriteLine(n2);
	
		
		
	}
}

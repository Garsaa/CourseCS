using System;
using System.Globalization;					
public class Program
{
	public static void Main()
	{

int qdia;
string dia;
		
Console.WriteLine("Qual dia da semana representado pelo número?");
qdia = int.Parse(Console.ReadLine());

switch(qdia){
	case 1: dia = "Domingo";
		break;
	case 2: dia = "Segunda";
		break;
	case 3: dia = "Terça";
		break;
	case 4: dia = "Quarta";
		break;
	case 5: dia = "Quinta";
		break;
	case 6: dia = "Sexta";
		break;
	case 7: dia = "Sábado";
		break;
	default: dia = "Valor inválido";
	   break;
}
	
	Console.WriteLine("Dia da semana :" + dia);



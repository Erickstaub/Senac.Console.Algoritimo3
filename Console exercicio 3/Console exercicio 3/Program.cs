// See https://aka.ms/new-console-template for more information
using System.Globalization;

Console.WriteLine("Qual seu nome completo?");
string nome = Console.ReadLine();
Console.WriteLine();
Console.WriteLine("quantos quartos tem na sua casa");
int quartos = int.Parse(Console.ReadLine());
Console.WriteLine();
Console.WriteLine("qual sua idade?");
int idade = int.Parse(Console.ReadLine());
Console.WriteLine();
Console.WriteLine("qual sua altura?");
float altura = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.WriteLine();
Console.WriteLine("quanto você paga na sua internet?");
double internet = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
Console.WriteLine();
Console.WriteLine("Qual seu ultimo nome?");
string sobrenome = Console.ReadLine();
Console.WriteLine();
Console.WriteLine("seus dados: " + "\n" + "\n" + nome + "\n" + quartos + "\n" +  altura + "\n" + "R$" + internet.ToString("F2") + "\n" + sobrenome);
Console.ReadKey();
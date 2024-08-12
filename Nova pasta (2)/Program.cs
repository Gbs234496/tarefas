/*
Console.WriteLine("Digite seu nome");
var informação = Console.ReadLine();
Console.WriteLine("olá, " + informação + ", digite o valor de a:");

var a = int.Parse(Console.ReadLine());
Console.WriteLine("Digite agora o valor de b:");
var b = int.Parse(Console.ReadLine());

Console.WriteLine("A soma de a e b é: " + (a + b));
*/

Console.WriteLine("Digite um numero:");
int nun = int.Parse(Console.ReadLine());
bool par = nun % 2 == 0;

if(par)
{
    Console.WriteLine("é par");
}
else
{
    Console.WriteLine("é ímpar");
}
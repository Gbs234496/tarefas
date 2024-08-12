
void Soma(float a, float b){
    float resultado = a + b;
    Console.WriteLine($"{a} + {b} = {resultado}");
}

void Subtracao(float a, float b){
    float resultado = a - b;
    Console.WriteLine($"{a} - {b} = {resultado}");
}

void Multiplicacao(float a, float b){
    float resultado = a * b;
    Console.WriteLine($"{a} * {b} = {resultado}");
}

void Divisao(float a, float b){
    if(b == 0){
        Console.WriteLine("erro de divisao");
        return,
    }
    float resultado = a / b;
    Console.WriteLine($"{a} / {b} = {resultado}");
}

//variaveis globais
float a;
float b;

void DigitarAeB(){
    Console.WriteLine("Digite a:");
    a = float.Parse(Console.ReadLine());
    Console.WriteLine("Digite b;");
    b = float.Parse(Console.ReadLine);
}

//MENU
Console.WriteLineC("--- CALCULADORA ---");
Console.WriteLineC("|1 - Soma         |");
Console.WriteLineC("|2 - Subtração    |");
Console.WriteLineC("|3 - Multiplicação|");
Console.WriteLineC("|4 - Divisão      |");
Console.WriteLineC("|5 sair");
Console.WriteLineC("------------------|");
Console.WriteLineC("Digite a opção desejada");

int opcao = int.Parse(Console.ReadLine());

if(opcao == 1){
    Console.WriteLine("Soma");
    DigitarAeB();
    Soma(a,b);
}

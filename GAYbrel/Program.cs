
Console.WriteLine("digite a nota 1:");
int nota1 = int.Parse(Console.ReadLine());

Console.WriteLine("digite a nota 2:");
int nota2 = int.Parse(Console.ReadLine());

Console.WriteLine("digite a nota 3:");
int nota3 = int.Parse(Console.ReadLine());

Console.WriteLine("digite a nota 4:");
int nota4 = int.Parse(Console.ReadLine());

float media = (2*nota1 + 2*nota2 + 3*nota3 + 3*nota4) / 10f;
media = (float)Math.Round(media);
Console.WriteLine("média da disciplina: " + media); 

if(media >= 60){
    Console.WriteLine("aprovado");
    return;
}
else if(media < 20){
    Console.WriteLine("reprovado");
    return;
}
else{
    Console.WriteLine("recuperação");
    float previsao = 120 - media;
    Console.WriteLine($"precisa de {previsao} para passar de ano");
}

Console.WriteLine("Digite o valor da prova final:");
int provaFinal = int.Parse(Console.ReadLine());

float mediaFinal = (media + provaFinal) / 2F;
mediaFinal = (float)Math.Round(mediaFinal);
Console.WriteLine("media final: " + mediaFinal);

if(mediaFinal >= 60){
    Console.WriteLine("aprovado");
}
    else{
        Console.WriteLine("repprovado");
}
    
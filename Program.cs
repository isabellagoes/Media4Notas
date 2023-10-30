//Resultados possíveis:
//"Reprovado" para médias menores que 5.0
//"Em recuperação" para médias entre 5.0 e 6.0
//"Aprovado", para médias acima de 6.0

double nota1, nota2, nota3, nota4, media;


Console.WriteLine("--- Média ---\n");

Console.WriteLine("Digite as suas notas abaixo.");
 
Console.Write("Nota 1: ");
nota1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Nota 2: ");
nota2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Nota 3: ");
nota3 = Convert.ToDouble(Console.ReadLine());

Console.Write("Nota 4: ");
nota4 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine();


if (nota1 < 0 || nota1 > 10
 || nota2 < 0 || nota2 > 10
 || nota3 < 0 || nota3 > 10
 || nota4 < 0 || nota4 > 10)
{
    Console.WriteLine("Digite a seguir somente notas entre 0 e 10.");     
}

else
{
    media = (nota1 + nota2 + nota3 + nota4) / 4;
 
    if (media < 5)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Reprovado");
    }
    else if (media > 6)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Aprovado");
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine("Em recuperação");
    }
}

        Console.ResetColor();
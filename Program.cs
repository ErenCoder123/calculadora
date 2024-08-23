// See https://aka.ms/new-console-template for more information
double num1;

Console.WriteLine("Digite o primeiro número:");
num1 = Convert.ToDouble(Console.ReadLine());

double num2;

Console.WriteLine("Digite o segundo número:");
num2 = Convert.ToDouble(Console.ReadLine());

double num3 = num1 + num2;
double num4 = num1 - num2;
double num5 = num1 / num2;
double num6 = num1 * num2;

//concatenação

Console.WriteLine("O resultado da soma é: " + num3);
Console.WriteLine("O resultado da subtração é: " + num4);
Console.WriteLine("O resultado da divisão é: " + num5);
Console.WriteLine("O resultado da multiplicação é: " + num6);

//interpolação

Console.WriteLine($"O resultado da soma é: {num3} ");
Console.WriteLine($"O resultado da subtração é: {num4}" );
Console.WriteLine($"O resultado da divisão é: {num5}");
Console.WriteLine($"O resultado da multiplicação é: {num6}");

//placeholders
Console.WriteLine("O resultado da soma é: {0:} ", num3);
Console.WriteLine("O resultado da subtração é: {0:} ", num4);
Console.WriteLine("O resultado da divisão é: {0:} ", num5);
Console.WriteLine("O resultado da multiplicação é: {0:} ", num6);


//fiz essa aula em casa, ai nao consegui tirar algumas duvidas, por exemplo como quebrar uma linha entre os resultados e se eu fiz oq foi proposto na TDE
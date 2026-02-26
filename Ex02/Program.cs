/*Desenvolva um código onde o usuário possa escolher converter uma temperatura de Celsius para Fahrenheit, 
de Celsius para Kelvin, de  Fahrenheit para Celsius, de Fahrenheit para Kelvin, de Kelvin para Fahrenheit 
e de Kelvin para Celsius.
*/

int opcao;
double celsius, fahrenheit, kelvin, resultado;
Console.WriteLine("Escolha qual temperetura você gostaria de converter: ");
Console.WriteLine("[1] Celsius para Fahrenheit \n[2] Celsius para Kelvin\n[3] Fahrenheit para Celsius \n[4] Fahrenheit para Kelvin \n[5] Kelvin para Fahrenheit \n[6] Kelvin para Celsius");
opcao = int.Parse(Console.ReadLine());

switch (opcao)
{
    case 1:
    Console.WriteLine("Digite o valor em Celsius: ");
    celsius = double.Parse(Console.ReadLine());
    resultado = (celsius * 1.8) + 32;
    Console.WriteLine($"Resultado da conversão: {resultado}");
    break;

    case 2:
    Console.WriteLine("Digite o valor em Celsius: ");
    celsius = double.Parse(Console.ReadLine());
    resultado = celsius + 273.15;
    Console.WriteLine($"Resultado da conversão: {resultado}");
    break;

    case 3:
    Console.WriteLine("Digite o valor em Fahrenheit: ");
    fahrenheit = double.Parse(Console.ReadLine());
    resultado = (fahrenheit - 32) / 1.8;
    Console.WriteLine($"Resultado da conversão: {resultado}");
    break;

    case 4:
    Console.WriteLine("Digite o valor em Fahrenheit: ");
    fahrenheit = double.Parse(Console.ReadLine());
    resultado = (fahrenheit - 32) / 1.8 + 273.15;
    Console.WriteLine($"Resultado da conversão: {resultado}");
    break;

    case 5:
    Console.WriteLine("Digite o valor em Kelvin: ");
    kelvin = double.Parse(Console.ReadLine());
    resultado = ((kelvin - 273.15) * 1.8) + 32;
    Console.WriteLine($"Resultado da conversão: {resultado}");
    break;

    case 6:
    Console.WriteLine("Digite o valor em Kelvin: ");
    kelvin = double.Parse(Console.ReadLine());
    resultado = kelvin - 273.15;
    Console.WriteLine($"Resultado da conversão: {resultado}");
    break;

    default:
    Console.WriteLine("Opção Inválida!");
    break;
}
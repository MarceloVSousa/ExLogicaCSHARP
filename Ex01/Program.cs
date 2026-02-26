// Números pares entre 1 e número aleatório sorteado

Random numero = new Random();

int valor = numero.Next(1,101);

for(int i = 1; i <= valor; i++)
{
    if (i % 2 == 0)
    {
        Console.WriteLine(i);
    }
}
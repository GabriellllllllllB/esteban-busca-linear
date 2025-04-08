
using System.Diagnostics.Contracts;

int[] n = { 2,5,7,4,2,5,7,8,7 };
int nprocurado = 7;
int contagem;

contagem = contar(n, nprocurado);

Console.WriteLine($"o numero {nprocurado} apareceu {contagem} vezes no array.");

static int contar(int[] array, int nprocurado)
{
    int contagem = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == nprocurado)
        {
            contagem++;
        }
    }
    return contagem;
}
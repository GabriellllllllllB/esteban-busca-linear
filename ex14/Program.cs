int[] n = { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20 };
int x = 7;
int resultado;

resultado = maior(n, x);

if (resultado != -1)
{
    Console.WriteLine($"O maior número menor que {x} é {resultado}");
}
else
{
    Console.WriteLine($"Não existe número menor que {x}");
}

static int maior(int[] array, int x)
{
    int inicio = 0;
    int fim = array.Length - 1;
    int meio;
    int resultado = -1;

    while (inicio <= fim)
    {
        meio = (inicio + fim) / 2;
        if (array[meio] < x)
        {
            resultado = array[meio];
            inicio = meio + 1;
        }
        else
        {
            fim = meio - 1;
        }
    }
    return resultado;
}

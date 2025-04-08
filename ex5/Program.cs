int[] n = {5, 13, 15, 18, 20 };
int x = 3;

int resultado = buscar(n, x);

if (resultado != -1)
{
    Console.WriteLine($"o primeiro numero múltiplo de {x} achado no array é {resultado}.");
}
else
{
    Console.WriteLine("nenhum numero achado");
}

    static int buscar(int[] array, int x)
{
    int i;
    for (i = 0; i < array.Length; i++)
    {
        if (array[i] % x == 0)
        {
            return array[i];
        }
    }

    return -1;
}
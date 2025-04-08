int[] n = {10, 20, 30, 40 ,50 ,60 ,70, 80, 90, 100 };
int valor = 30;
int busca;

busca = buscar(n, valor);

if (busca != -1)
{
    Console.WriteLine($"o valor {valor} achado na busca {busca}.");
}
else
{
    Console.WriteLine("valor não achado.");
}
static int buscar(int[] array, int valor)
{
    int i;
    for (i = 0; i < array.Length; i++)
    {
        if (array[i] == valor)
        {
            return i;
        }
    }

    return -1;
}

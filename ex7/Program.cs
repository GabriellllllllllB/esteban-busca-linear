int[] n = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
int nprocurado = 3;

int lugar = buscar(n, nprocurado);

if (lugar != -1)
{
    Console.WriteLine($"ultima ocorrência do valor {nprocurado} está no lugar {lugar}.");
}
else
{
    Console.WriteLine("valor não achado");
}


    static int buscar(int[] array, int valor)
{
    int lugar = -1;
    int i;

    for (i = 0; i < array.Length; i++)
    {
        if (array[i] == valor)
        {
            lugar = i;
        }
    }

    return lugar;
}
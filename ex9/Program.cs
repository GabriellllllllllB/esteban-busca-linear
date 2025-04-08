int[] n = { 10, 25, 30, 45, 60 };
int nprocurado = 45;

int lugar = buscar(n, nprocurado);

if (lugar != -1)
{
    Console.WriteLine($"numero {nprocurado} encontrado no lugar {lugar}.");
}
else
{
    Console.WriteLine("numero não encontrado.");
}


    static int buscar(int[] arrayn, int valor)
{
    int n = arrayn.Length;
    int[] array = new int[n + 1];
    Array.Copy(arrayn, array, n);
    array[n] = valor;

    int i = 0;
    while (array[i] != valor)
    {
        i++;
    }

    return (i < n) ? i : -1;
}
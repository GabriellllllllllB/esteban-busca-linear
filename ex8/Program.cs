int[] n = { 11, 8, 16, 1, 55, 17, 8, 20, 13 };
int primeiropar = encontrapar(n);

if ( primeiropar != -1)
{
    Console.WriteLine($"O primeiro par é {n[primeiropar]}");
}
else
{
    Console.WriteLine("Não há números pares no array");
}

static int encontrapar(int[] array)
{
    int i;
    for (i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            return i;
        }
    }
    return array[i];
}
int[] n = { 2, 4, 6, 8, 10, 12, 14, 16, 18 };
int valor;

Console.Write("escreva o número que deseja procurar: ");
valor = int.Parse(Console.ReadLine());

if (lista(n, valor))
    Console.WriteLine("o número existe na lista.");
else
    Console.WriteLine("o número não existe");

static bool lista(int[] lista, int numero)
{
    int inicio = 0;
    int fim = lista.Length - 1;

    while (inicio <= fim)
    {
        int meio = (inicio + fim) / 2;

        if (lista[meio] == numero)
            return true;
        else if (lista[meio] < numero)
            inicio = meio + 1;
        else
            fim = meio - 1;
    }

    return false;
}
int[] n = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
int novon = 10;
int posicao;

posicao = novaposicao(n, novon);

Console.WriteLine($"o número {novon} deve estar na posição {posicao}");

static int novaposicao(int[] array, int valor)
{
    int inicio = 0;
    int fim = array.Length;
    int meio;

    while (inicio < fim)
    {
        meio = (inicio + fim) / 2;

        if (array[meio] < valor)
        {
            inicio = meio + 1;
        }
        else
        {
            fim = meio;
        }
    }
    return inicio;
}

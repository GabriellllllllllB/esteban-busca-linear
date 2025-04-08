int[] numeros = { 2, 4, 6, 8, 10, 12, 14 };

Console.Write("Digite o número que deseja inserir: ");
int x = int.Parse(Console.ReadLine());

int posicao = PosicaoInsercao(numeros, x);

Console.WriteLine("O número deve ser inserido na posição: " + posicao);

    static int PosicaoInsercao(int[] lista, int x)
{
    int inicio = 0;
    int fim = lista.Length;

    while (inicio < fim)
    {
        int meio = (inicio + fim) / 2;

        if (lista[meio] < x)
            inicio = meio + 1;
        else
            fim = meio;
    }

    return inicio;
}

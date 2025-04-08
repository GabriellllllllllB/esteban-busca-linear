int[] numeros = { 2, 4, 6, 8, 10, 12, 14 };

Console.Write("Digite o valor de X: ");
int x = int.Parse(Console.ReadLine());

int maisProximo = NumeroMaisProximo(numeros, x);

Console.WriteLine("Número mais próximo de X: " + maisProximo);
    static int NumeroMaisProximo(int[] lista, int x)
{
    int inicio = 0;
    int fim = lista.Length - 1;
    int maisProximo = lista[0];

    while (inicio <= fim)
    {
        int meio = (inicio + fim) / 2;

        if (lista[meio] == x)
            return lista[meio];

        if (Math.Abs(lista[meio] - x) < Math.Abs(maisProximo - x))
            maisProximo = lista[meio];
        else if (Math.Abs(lista[meio] - x) == Math.Abs(maisProximo - x) && lista[meio] < maisProximo)
            maisProximo = lista[meio];

        if (lista[meio] < x)
            inicio = meio + 1;
        else
            fim = meio - 1;
    }

    return maisProximo;
}
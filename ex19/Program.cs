int[] numeros = { 1, 2, 4, 4, 4, 5, 6, 7 };

Console.Write("Digite o número que deseja encontrar: ");
int x = int.Parse(Console.ReadLine());

int posicao = UltimaOcorrencia(numeros, x);

if (posicao != -1)
    Console.WriteLine("Última ocorrência na posição: " + posicao);
else
    Console.WriteLine("Número não encontrado na lista.");

    static int UltimaOcorrencia(int[] lista, int x)
{
    int inicio = 0;
    int fim = lista.Length - 1;
    int resultado = -1;

    while (inicio <= fim)
    {
        int meio = (inicio + fim) / 2;

        if (lista[meio] == x)
        {
            resultado = meio;
            inicio = meio + 1;
        }
        else if (lista[meio] < x)
        {
            inicio = meio + 1;
        }
        else
        {
            fim = meio - 1;
        }
    }

    return resultado;
}
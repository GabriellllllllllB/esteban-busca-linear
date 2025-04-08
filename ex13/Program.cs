int[] numeros = { 2, 4, 6, 8, 10, 12, 14 };

Console.Write("Digite o número X: ");
int x = int.Parse(Console.ReadLine());

int resultado = MaiorMenorQueX(numeros, x);

if (resultado == -1)
    Console.WriteLine("Não existe número menor que X na lista.");
else
    Console.WriteLine("Maior número menor que X: " + resultado);

    static int MaiorMenorQueX(int[] lista, int x)
{
    int inicio = 0;
    int fim = lista.Length - 1;
    int resultado = -1;

    while (inicio <= fim)
    {
        int meio = (inicio + fim) / 2;

        if (lista[meio] < x)
        {
            resultado = lista[meio];
            inicio = meio + 1;
        }
        else
        {
            fim = meio - 1;
        }
    }

    return resultado;
}
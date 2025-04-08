string[] dicionario = { "abacate", "banana", "cachorro", "dado", "elefante", "foca", "gato" };

Console.Write("Digite a palavra que deseja procurar: ");
string palavra = Console.ReadLine();

bool existe = PalavraExiste(dicionario, palavra);

if (existe)
    Console.WriteLine("A palavra existe no dicionário.");
else
    Console.WriteLine("A palavra NÃO existe no dicionário.");

    static bool PalavraExiste(string[] lista, string palavra)
{
    int inicio = 0;
    int fim = lista.Length - 1;

    while (inicio <= fim)
    {
        int meio = (inicio + fim) / 2;
        int comparacao = string.Compare(lista[meio], palavra, StringComparison.OrdinalIgnoreCase);

        if (comparacao == 0)
            return true;
        else if (comparacao < 0)
            inicio = meio + 1;
        else
            fim = meio - 1;
    }

    return false;
}
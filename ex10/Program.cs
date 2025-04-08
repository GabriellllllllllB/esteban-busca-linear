int posicao;

Console.WriteLine("escreva seu texto: ");
string texto = Console.ReadLine();

Console.WriteLine("escreva a palavra que deseja achar: ");
string palavra = Console.ReadLine();

posicao = buscarpalavra(texto, palavra);

if (posicao != -1)
{
    Console.WriteLine($"palavra {palavra} achada na posição {posicao}");
}
else
{
    Console.WriteLine("palavra não achada");
}

static int buscarpalavra(string texto, string palavra)
{
    for (int i = 0; i < texto.Length - palavra.Length; i++)
    {
        if (texto.Substring(i, palavra.Length) == palavra)
        {
            return i;
        }
    }
    return -1;
}
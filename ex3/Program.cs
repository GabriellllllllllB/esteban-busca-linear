string[] n = { "Gabriel", "João", "Tharso", "Marcus" };
string nprocurado = "Gabriel";
int indice;

indice = buscar(n, nprocurado);

if (indice != -1)
{
    Console.WriteLine($"nome {nprocurado} achado no índice {indice}.");
}
else
{
    Console.WriteLine($"nome{nprocurado} não achado na lista.");
}

    static int buscar(string[] lista, string nome)
{
    for (int i = 0; i < lista.Length; i++)
    {
        if (lista[i] == nome)
        {
            return i;
        }
    }
    return -1;
}



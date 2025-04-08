using System.Reflection;

int[] n = { 50, 100, 200, 240, 210, 270 };
int maior = emaior(n);
int menor = emenor(n);
Console.WriteLine($"o maior número é: {maior}");
Console.WriteLine($"o menor número é: {menor}");

int emaior(int[] array)
{
    int maior = array[0];
    int i;
    for (i = 1; i < array.Length; i++)
    {
        if (array[i] > maior)
        {
            maior = n[i];
        }
    }
    return maior;
}

int emenor(int[] array)
{
    int menor = array[0];
    int i;
    for (i = 1; i < n.Length; i++)
    {
        if (array[i] < menor)
        {
            menor = n[i];
        }
    }
    return menor;
}
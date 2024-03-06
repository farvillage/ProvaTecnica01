using System;
public static class Program
{
    static void Main(string[] args)
    {
        string textoOriginal = "Exemplo de string a ser invertida";

        string textoInvertido = InverterString(textoOriginal);

        Console.WriteLine("Texto original: " + textoOriginal);
        Console.WriteLine("Texto invertido: " + textoInvertido);
    }
    static string InverterString(string texto)
    {
        char[] caracteres = texto.ToCharArray();
        int inicio = 0;
        int fim = caracteres.Length - 1;

        while (inicio < fim)
        {
            char temp = caracteres[inicio];
            caracteres[inicio] = caracteres[fim];
            caracteres[fim] = temp;

            inicio++;
            fim--;
        }

        return new string(caracteres);
    }
}


using System;

class Program
{
    static void Main(string[] args)
    {
        static int ContarPalabrasConDosVocales(string oracion)
{
    // Dividir la oración en palabras utilizando los espacios como delimitadores
    string[] palabras = oracion.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

    int contador = 0;
    // Contar las palabras que tienen al menos dos vocales
    foreach (string palabra in palabras)
    {
        int cantidadVocales = 0;
        foreach (char letra in palabra)
        {
            // Verificar si la letra es una vocal
            if ("aeiouAEIOU".IndexOf(letra) != -1)
            {
                cantidadVocales++;
                if (cantidadVocales >= 2)
                {
                    contador++;
                    break; // Romper el bucle interno si ya se encontraron al menos dos vocales
                }
            }
        }
    }
    return contador;
}
}
}
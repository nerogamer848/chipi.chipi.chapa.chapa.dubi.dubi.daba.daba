using System;

class Program
{
    static void Main(string[] args)
    {
        int[] vector = { 1, 2, 3, 4, 5 };

        Console.WriteLine("Vector original:");
        ImprimirVector(vector);

        int[] vectorVolteado = VoltearVector(vector);

        Console.WriteLine("Vector volteado:");
        ImprimirVector(vectorVolteado);

        int suma = SumarElementosVector(vectorVolteado);
        Console.WriteLine("Suma de los elementos del vector volteado: " + suma);
    }

    static int[] VoltearVector(int[] vector)
    {
        int[] vectorVolteado = new int[vector.Length];
        for (int i = 0; i < vector.Length; i++)
        {
            vectorVolteado[i] = vector[vector.Length - 1 - i];
        }
        return vectorVolteado;
    }

    static int SumarElementosVector(int[] vector)
    {
        int suma = 0;
        foreach (int elemento in vector)
        {
            suma += elemento;
        }
        return suma;
    }

    static void ImprimirVector(int[] vector)
    {
        foreach (int elemento in vector)
        {
            Console.Write(elemento + " ");
        }
        Console.WriteLine();
    }
}
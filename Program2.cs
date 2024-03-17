
using System;

class Program
{
   static void Main(string[] args)
 {
     int numero = 3557867;
     int nuevoNumero = VoltearNumero(numero);
     Console.WriteLine("Número original: " + numero);
     Console.WriteLine("Número rotado: " + nuevoNumero);





 }






 static int VoltearNumero(int numero)
 {
     // Convertimos el número a una cadena para manipular sus dígitos
     string numeroString = numero.ToString();

     // Invertimos la cadena de dígitos
     char[] arrayDigitos = numeroString.ToCharArray();
     Array.Reverse(arrayDigitos);
     numeroString = new string(arrayDigitos);

     // Convertimos la cadena resultante de nuevo a un número
     int nuevoNumero = int.Parse(numeroString);
     return nuevoNumero;
 }
}
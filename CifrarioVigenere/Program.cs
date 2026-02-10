using System;

namespace CifrarioVigenere
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ESERCIZIO CIFRARIO VIGENERE");
            Console.WriteLine("");

            Console.WriteLine("Inserisci una frase da cifrare");
            string parola = Console.ReadLine();

            Console.WriteLine("inserisci parola k");
            string codice= Console.ReadLine();

            Console.WriteLine("Premi un tasto per avviare la cifratura");
            Console.ReadLine();

            char[] Arrayparola = parola.ToCharArray();

            char[] alfabeto = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

  

        }
    }
}

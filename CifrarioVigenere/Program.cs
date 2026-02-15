using System;

namespace CifrarioVigenere
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ESERCIZIO CIFRARIO VIGENERE");
            Console.WriteLine("");

            Console.WriteLine("Inserisci una frase da cifrare:");
            string frase = Console.ReadLine().ToLower();

            //  Rimuovo gli spazi con un for
            string fraseSenzaSpazi = "";

            for (int i = 0; i < frase.Length; i++)
            {
                if (frase[i] != ' ')
                {
                    fraseSenzaSpazi = fraseSenzaSpazi + frase[i];
                }
            }

            frase = fraseSenzaSpazi;

            Console.WriteLine("Inserisci la parola chiave:");
            string chiave = Console.ReadLine().ToLower();

            // Allungo la chiave fino alla lunghezza della frase
            string chiaveEstesa = "";
            int indice = 0;

            for (int i = 0; i < frase.Length; i++)
            {
                chiaveEstesa = chiaveEstesa + chiave[indice];

                indice++;

                if (indice == chiave.Length)
                {
                    indice = 0;
                }
            }

            char[] alfabeto = { 'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z' };

            //  Cifratura
            string risultato = "";

            for (int i = 0; i < frase.Length; i++)
            {
                int posizioneFrase = 0;
                int posizioneChiave = 0;

                // Trovo posizione lettera frase
                for (int j = 0; j < 26; j++)
                {
                    if (alfabeto[j] == frase[i])
                    {
                        posizioneFrase = j;
                    }
                }

                // Trovo posizione lettera chiave estesa
                for (int j = 0; j < 26; j++)
                {
                    if (alfabeto[j] == chiaveEstesa[i])
                    {
                        posizioneChiave = j;
                    }
                }

                int nuovaPosizione = posizioneFrase + posizioneChiave;

                if (nuovaPosizione >= 26)
                {
                    nuovaPosizione = nuovaPosizione - 26;
                }

                risultato = risultato + alfabeto[nuovaPosizione];
            }

            Console.WriteLine("");
            Console.WriteLine("Chiave estesa: " + chiaveEstesa);
            Console.WriteLine("Frase cifrata: " + risultato);

            Console.ReadLine();
        }
    }
}

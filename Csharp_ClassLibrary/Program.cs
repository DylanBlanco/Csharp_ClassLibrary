

namespace Csharp_ClassLibrary
{
    public class Program
    {
        // CREA ARRAY DI 10 NUM GENERATI CASUALMENTE E CHIEDI ALL'UTENTE DI INDOVINARE DUE NUMERI
        public static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] numeriCasuali = new int[10];

            // genera i numeri casuali
            for (int i = 0; i < numeriCasuali.Length; i++)
            {
                numeriCasuali[i] = rnd.Next(1, 11);
            }

            Console.WriteLine("Numeri generati: " + string.Join(", ", numeriCasuali));

            while (true)
            {
                // chiedi i due numeri all'utente
                Console.Write("Indovina il primo numero (1-10): ");
                int num1 = int.Parse(Console.ReadLine());

                Console.Write("Indovina il secondo numero (1-10): ");
                int num2 = int.Parse(Console.ReadLine());

                // controlla se sono presenti
                bool trovato1 = numeriCasuali.Contains(num1);
                bool trovato2 = numeriCasuali.Contains(num2);

                // mostra il risultato
                if (trovato1 && trovato2)
                {
                    Console.WriteLine("Hai indovinato entrambi i numeri!");
                    break;
                }
                else if (trovato1 || trovato2)
                    Console.WriteLine("Hai indovinato solo uno dei due numeri!");
                else
                    Console.WriteLine("Non hai indovinato nessuno dei numeri!");
            }

            Console.WriteLine("Fine del gioco. Grazie per aver giocato!");
        }
    }
}
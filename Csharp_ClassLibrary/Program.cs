using System;
using System.Linq;
using System.Security.Cryptography;

namespace Csharp_ClassLibrary
{
    public class Program
    {
        // CREA ARRAY DI 10 NUM GENERATI CASUALMENTE E CHIEDI ALL'UTENTE DI INDOVINARE DUE NUMERI
        public static void Main(string[] args)
        {
            var stratGame = new ClassLibrary_gioco.Class_Gioco();
            Console.WriteLine(stratGame.IniziaGioco());

            bool continuaGioco = true;

            while (continuaGioco)
            {
                // genera i numeri casuali
                var numGen = new ClassLibrary_gioco.Class_Gioco();
                int[] arrNumRan = numGen.GenRandomNum();
                Console.WriteLine("Numeri generati: " + string.Join(", ", arrNumRan));

                int numTentativi = 0;

                while (true)
                {
                    // CLASSE CHE CONTA I TENTATIVI
                    var countTent = new ClassLibrary_gioco.Class_Gioco();
                    numTentativi = countTent.ContaTentativi(numTentativi);

                    // chiedi i due numeri all'utente
                    Console.Write("Indovina il primo numero (1-10): ");
                    int num1 = int.Parse(Console.ReadLine());
                    Console.Write("Indovina il secondo numero (1-10): ");
                    int num2 = int.Parse(Console.ReadLine());

                    // CLASSE CONTROLLA SE I NUMERI SONO PRESENTI
                    var checkNum = new ClassLibrary_gioco.Class_Gioco();

                    // controlla se sono presenti
                    bool trovato1 = checkNum.ControllaNum(arrNumRan, num1);
                    bool trovato2 = checkNum.ControllaNum(arrNumRan, num2);
                    // mostra il risultato
                    if (trovato1 && trovato2)
                    {
                        Console.WriteLine("Hai indovinato entrambi i numeri!");
                        Console.WriteLine("Numero di tentativi fatti: " + numTentativi);
                        break;
                    }
                    else if (trovato1 || trovato2)
                        Console.WriteLine("Hai indovinato solo uno dei due numeri!");
                    else
                        Console.WriteLine("Non hai indovinato nessuno dei numeri!");
                }

                // Dopo la vittoria, chiedi se vuole giocare di nuovo
                Console.Write("\nVuoi giocare di nuovo? (s/n): ");
                string risposta = Console.ReadLine().ToLower();
                if (risposta != "s" && risposta != "si")
                {
                    continuaGioco = false;
                    Console.WriteLine("Fine del gioco. Grazie per aver giocato!");
                }
            }
        }
    }
}
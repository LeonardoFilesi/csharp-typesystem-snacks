using System.Globalization;

namespace Csharp_typesystem_snacks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World! Proparatevi, perchè l'esercizio sarà tedioso! <3");

            //Sanck 1: Utente inserisce 2 numeri. Console stampa il maggiore

            Console.WriteLine("Scrivimi un numero:");
            int firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Scrivi un altro numero:");
            int lastNumber = Convert.ToInt32(Console.ReadLine());

            if (firstNumber > lastNumber)
            {
                Console.WriteLine($"il numero maggiore che hai scritto è: {firstNumber}");
            }
            else if (firstNumber < lastNumber)
            {
                Console.WriteLine($"il numero maggiore che hai scritto è: {lastNumber}");
            }
            else { 
                Console.WriteLine("Hai scritto due numeri uguali"); 
            }



            //Sanck 2: Utente scrive due parole. Console stampa la più lunga, poi la più corta

            Console.WriteLine("Scrivimi una parola:");
            string firstWord = Console.ReadLine();

            Console.WriteLine("Scrivimi una seconda parola:");
            string lastWord = Console.ReadLine();

            if (firstWord.Length > lastWord.Length)
            {
                Console.WriteLine($"La parola più lunga è {firstWord}, mentre la più corta è{lastWord}");
            }
            else if (lastWord.Length > firstWord.Length)
            {
                Console.WriteLine($"La parola più lunga è {lastWord}, mentre la più corta è{firstWord}");
            }
            else
                Console.WriteLine($"Le due parole {firstWord} e {lastWord} sono lunghe uguali");



            //Snack 3: Chiedere per 10 volte a utente di scrivere un numero. Console stampa la somma di tutti i numeri

            //Opzione 1:

            Console.WriteLine("Ciao! Scrivimi un numero:");
            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Dai, scrivimi un altro numero");
            int number2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Dai, scrivimi un altro numero");
            int number3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Su su, voglio un numero:");
            int number4 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Dai, scrivimi un altro numero");
            int number5 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Dai, scrivimi un altro numero");
            int number6 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ancora un altro, manca poco:");
            int number7 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Dai, scrivimi un ultimo numero");
            int number8 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Dai, dai dai ultimissimo:");
            int number9 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Daaaaaaaaaaaaaaaaaaaaaaaai, ultimissimo peddavvero :) :");
            int number10 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Bravissimo! Grazie per la pazienza, la somma di tutti i tuoi numeri è:");

            //Che cagata; Opzione 2:

            int addition = 0;
            int[] numbers = new int[10];

            for (int i = 0; i < 10; i++) 
            {
                Console.WriteLine("Inserisci un numero:");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            foreach (int number in numbers)
            {
                addition += number;
            }

            Console.WriteLine($"Congratulazioni per la pazienza, la somma di tutti i tuoi numeri è: {addition}");



            //Snack 4: Stampa in console la somma e la media dei numeri da 2 a 10:

            int[] snack4numbers = { 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            foreach (int snack4number in snack4numbers) 
            {
                addition += snack4number;
            }
            int snack4media = addition / snack4numbers.Length;

            Console.WriteLine($"La somma dei numeri da 2 a 10 (compresi) è: {addition}. Mentre la loro media è: {snack4media}");



            //Snack5: Chiedere a utente di scrivere un numero. Se pari, stamparlo, se dispari, stampare il successivo:

            Console.WriteLine("Per piacere, scrivi un numero:");
            int snack5number = Convert.ToInt32(Console.ReadLine());

            if (snack5number % 2 == 0) 
            {
                Console.WriteLine($"Bene, {snack5number} è pari!");
            }
            else
            {
                Console.WriteLine($"Azz, quello che hai scritto è dispari, ti rispondo con questo {snack5number + 1}");
            }



            //Snack 6: Fai una festa e hai un array di nomi, fanne scrivere all'utente il suo e confrontalo con l'array per vedere se passa o no.

            string[] snack6nameList = { "Marco", "Aurelio", "Anna" , "Alberta", "MariaRosanna", "GianAlberto", "Davide", "Giovanna", "Giovanni", "Alberto" };
            Console.WriteLine("Scrivimi il tuo nome, è una festa PRIVATA: (scrivi Marco, o MariaRosanna, o prova ad essere fortunato e improvvisa");
            string guestName = Console.ReadLine();

            foreach (string nameInList6 in snack6nameList)
            {
                if (nameInList6 == guestName)
                {
                    Console.WriteLine($"Bene signor/a {nameInList6} può passare");
                }
                else
                {
                    Console.WriteLine($"Mi scusi signor/a {guestName}, ma lei non è in lista");
                }
            }



            //Snack 7: Crea Array vuoto. Chiedi per 6 volte a utente di inserire un numero, che andrà nell'array solo se dispari.

            int[] snack7UnEvenNumb = new int[6];

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine("Per piacere, inserisci un numero:");
                int snack7Number = Convert.ToInt32(Console.ReadLine());

                if (snack7Number % 2 == 0)
                {
                    snack7UnEvenNumb[i] = snack7Number;
                }
            }



            //Snack 8: Crea un array di numeri interi e somma tutti gli elementi in posizione dispari.
            
            int[] snack8Numbers = {1,2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };
            
            for (int i = 0; i < snack8Numbers.Length; i += 2) 
            {
                addition += snack8Numbers[i];
            }

            Console.WriteLine($"la somma dei numeri in posizione dispari è: {addition}");



            //Snack 9: Crea un array vuoto e fai inserire un numero da utente. Continua a chiedere altri numeri da inserire, finchè la somma è minore di 50 ???? cioè fin da subito
            // che vuol dire? ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^

            // Snack 10: Chiedi a utente un numero che chiameremo N. Crea N array, ognuno con 10 numeri dasuali da 1 a 100. Stampali ognuno su console, appena creato.

            Console.WriteLine("Siamo alla fine dai, scrivimi un ultimerrissimo numero:");
            int N = Convert.ToInt32(Console.ReadLine());

            Random random = new Random();

            for (int i = 0; i < N; i++)
            {
                int[] snack10Array = new int[10];
                
                for (int j = 0; j < snack10Array.Length; j++)
                {
                    snack10Array[j] = random.Next(1, 100);
                }

                Console.WriteLine($"Abbiamo {N} array, questo è il numero {i + 1}, composto da: ");
            }
        }
    }
}
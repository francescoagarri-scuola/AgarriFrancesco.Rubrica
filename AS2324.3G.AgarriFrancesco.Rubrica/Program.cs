using System;

namespace AS2324._3G.AgarriFrancesco.Rubrica
{
    internal class Program
    {  
        static void Main(string[] args)
        {
            string[] Cognomi = new string[100];
            string[] Nomi = new string[100];
            string[] Email = new string[100];
            int[] Simpatia = new int[100];
            string[] Nickname = new string[100];
            int[] Annonascita = new int[100];

            int elementiRubrica = 0;
            int scelta = 0;

            Console.WriteLine("benvenuto all'interno della rubrica");

            do
            {
                Console.WriteLine("inserire la scelta desiderata");

                Console.WriteLine("\n 1 = Inserimento completo di un nominativo");
                Console.WriteLine("\n 2 = Elenco dei nominativi inseriti");
                Console.WriteLine("\n 3 = Ricerca di un nominativo in base al Nickname");
                Console.WriteLine("\n 0 = Uscita");

                scelta = Convert.ToInt32(Console.ReadLine());

                switch (scelta)
                {
                    case 1:          

                        Console.WriteLine("\n inserire il cognome");
                        Cognomi[elementiRubrica] = Console.ReadLine();

                        Console.WriteLine("\n inserire il nome");
                        Nomi[elementiRubrica] = Console.ReadLine();

                        Console.WriteLine("\n inserire la posta elettronica");
                        Email[elementiRubrica] = Console.ReadLine();

                        Console.WriteLine("\n inserire la rispettiva simpatia ( da 1 a 5 )");
                        Simpatia[elementiRubrica] = Convert.ToInt32(Console.ReadLine());

                        while (Simpatia[elementiRubrica] < 1 || Simpatia[elementiRubrica] > 5)
                        {
                            Console.WriteLine("\n hai inserito un valore non valido, per favore inserire un valore tra 1 e 5");
                            Simpatia[elementiRubrica] = Convert.ToInt32(Console.ReadLine());
                        }

                        Console.WriteLine("\n inserire il Nickname");
                        Nickname[elementiRubrica] = Console.ReadLine();

                        Console.WriteLine("\n inserire l'anno di nascita");
                        Annonascita[elementiRubrica] = Convert.ToInt32(Console.ReadLine());

                        while (Annonascita[elementiRubrica] <= 1924 || Annonascita[elementiRubrica] >= 2024)
                        {
                            Console.WriteLine("\n hai inserito un valore non valido, per favore inserisci un valore tra 1924 e 2024");
                            Annonascita[elementiRubrica] = Convert.ToInt32(Console.ReadLine());
                        }

                        elementiRubrica++;

                        break;

                    case 2:

                        Console.WriteLine("ecco la stampa della rubrica\n");

                        Console.WriteLine("numero\tcognome\tnome\tEmail\tsimpatia\tnickname\tanno di nascita\n");

                        for (int i = 0; i < elementiRubrica; i++)
                        {
                            Console.WriteLine($"{i + 1}" + "\t" + Cognomi[i] + "\t" + Nomi[i] + "\t" + Email[i] + "\t" + Simpatia[i] + "\t" + Nickname[i] + "\t" + Annonascita[i] + "\n");
                        }

                        break;

                    case 3:

                        

                        break;

                    case 0:

                        Console.WriteLine("\n arrivederci!");

                        break;

                }

            } while (scelta != 0);

            Console.ReadLine();
        }
    }
}

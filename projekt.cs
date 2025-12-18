


namespace Quizspiel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Punkte = 0;

            // Frage 1
            Console.WriteLine("Wie heißt der höchste Berg der Welt?");
            Console.WriteLine("1 = Himalaya Gebirge");
            Console.WriteLine("2 = K2 (Godwin Austen)");
            Console.WriteLine("3 = Mount Everest");

            int eingabe = int.Parse(Console.ReadLine());

            if (eingabe == 3)
            {
                Punkte++;
                Console.WriteLine("Richtig!");
            }
            else
            {
                Console.WriteLine("Falsch!");
            }

            Console.WriteLine("Punkte: " + Punkte);
            Console.WriteLine();

            // Frage 2
            Console.WriteLine("Wie heißt die Hauptstadt von Deutschland?");
            Console.WriteLine("1 = München");
            Console.WriteLine("2 = Berlin");
            Console.WriteLine("3 = Hamburg");

            eingabe = int.Parse(Console.ReadLine());

            if (eingabe == 2)
            {
                Punkte++;
                Console.WriteLine("Richtig!");
            }
            else
            {
                Console.WriteLine("Falsch!");
            }

            Console.WriteLine("Punkte gesamt: " + Punkte);
            //Frage 3
            Console.WriteLine("Wie viele Kontinente gibt es auf der Erde?");
            Console.WriteLine("1 = 5");
            Console.WriteLine("2 =6");
            Console.WriteLine("3 = 7");

            eingabe = int.Parse(Console.ReadLine());

            if (eingabe == 3)
            {
                Punkte++;
                Console.WriteLine("Richtig!");
            }
            else
            {
                Console.WriteLine("Falsch!");
            }
            
            Console.WriteLine("Punkte gesamt: " + Punkte);
            //Frage 4
            Console.WriteLine("Welches Tier ist das größte lebende Landtier?");
            Console.WriteLine("1 = Elefant");
            Console.WriteLine("2 = Giraffe");
            Console.WriteLine("3 = Nashorn");

            eingabe = int.Parse(Console.ReadLine());

            if (eingabe == 1)
            {
                Punkte++;
                Console.WriteLine("Richtig!");
            }
            else
            {
                Console.WriteLine("Falsch!");
            }

            Console.WriteLine("Punkte gesamt: " + Punkte);
            //Frage 5
            Console.WriteLine("Wie viele Minuten hat eine Stunde?");
            Console.WriteLine("1 = 100");
            Console.WriteLine("2 = 60");
            Console.WriteLine("3 = 30");

            eingabe = int.Parse(Console.ReadLine());

            if (eingabe == 2)
            {
                Punkte++;
                Console.WriteLine("Richtig!");
            }
            else
            {
                Console.WriteLine("Falsch!");
            }

            Console.WriteLine("Punkte gesamt: " + Punkte);
            //Frage 6
            Console.WriteLine("Wer war der erste Mensch auf dem Mond?");
            Console.WriteLine("1 = Yuri Gagarin");
            Console.WriteLine("2 = Neil Armstrong");
            Console.WriteLine("3 = Buzz Aldrin");

            eingabe = int.Parse(Console.ReadLine());

            if (eingabe == 2)
            {
                Punkte++;
                Console.WriteLine("Richtig!");
            }
            else
            {
                Console.WriteLine("Falsch!");
            }

            Console.WriteLine("Punkte gesamt: " + Punkte);
            //Frage 7
            Console.WriteLine("Welcher Planet ist der Sonne am nächsten?");
            Console.WriteLine("1 = Venus");
            Console.WriteLine("2 = Mars");
            Console.WriteLine("3 = Merkur");

            eingabe = int.Parse(Console.ReadLine());

            if (eingabe == 3)
            {
                Punkte++;
                Console.WriteLine("Richtig!");
            }
            else
            {
                Console.WriteLine("Falsch!");
            }

            Console.WriteLine("Punkte gesamt: " + Punkte);
            //Frage 8
            Console.WriteLine("In welchem Jahr begann der Zweite Weltkrieg?");
            Console.WriteLine("1 = 1939");
            Console.WriteLine("2 = 1945");
            Console.WriteLine("3 = 1918");

            eingabe = int.Parse(Console.ReadLine());

            if (eingabe == 1   )
            {
                Punkte++;
                Console.WriteLine("Richtig!");
            }
            else
            {
                Console.WriteLine("Falsch!");
            }

            Console.WriteLine("Punkte gesamt: " + Punkte);
            //Frage 9
            Console.WriteLine("Wie heißt das chemische Symbol für Wasser?");
            Console.WriteLine("1 = CO₂");
            Console.WriteLine("2 = H₂O");
            Console.WriteLine("3 = O₂");

            eingabe = int.Parse(Console.ReadLine());

            if (eingabe == 2)
            {
                Punkte++;
                Console.WriteLine("Richtig!");
            }
            else
            {
                Console.WriteLine("Falsch!");
            }

            Console.WriteLine("Punkte gesamt: " + Punkte);
            //Frage 10
            Console.WriteLine("Welches Land ist für den Eiffelturm bekannt?");
            Console.WriteLine("1 = Italien");
            Console.WriteLine("2 = Spanien");
            Console.WriteLine("3 = Frankreich");

            eingabe = int.Parse(Console.ReadLine());

            if (eingabe == 3)
            {
                Punkte++;
                Console.WriteLine("Richtig!");
            }
            else
            {
                Console.WriteLine("Falsch!");
            }

            Console.WriteLine("Punkte gesamt: " + Punkte);
            Console.WriteLine($"Du hast {Punkte} von 10 erreicht");
        }
        
    }
}

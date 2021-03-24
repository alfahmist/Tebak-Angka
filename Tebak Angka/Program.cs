using System;

namespace Tebak_Angka
{
    class Program
    {
        static void Main(string[] args)
        {
            // variabel awal
            int skor = 0;
            int percobaan = 1;
            int playerTebak = 0;
            bool play = true;

            // Generate angka random dari 1 - 100
            Random random = new Random();
            int randomAngka = random.Next(1,100);

            // Info game
            Console.WriteLine("Game Console Tebak Angka");
            Console.WriteLine("Tebak angka dari 1 - 100");
            Console.WriteLine("Kebesaran : angka yang dimasukkan lebih dari angka random");
            Console.WriteLine("Kekecilan : angka yang dimasukkan kurang dari angka random");
            Console.WriteLine("Makin dekat : angka yang dimasukkan mendekati jarak 5 dari angka random");
            Console.WriteLine();
            while (play)
            {
                Console.WriteLine($"Percobaan ke - {percobaan}");
                Console.Write("Tebak Angka : ");
                playerTebak = Convert.ToInt32(Console.ReadLine());
                
                if (playerTebak == randomAngka)
                {
                    Console.WriteLine($"HOREEE !! kamu Benar angkanya adalah : {randomAngka}");
                    play = false;
                }

                else if (playerTebak > randomAngka)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Kebesaran");
                    if ((playerTebak - randomAngka) <= 5)
                    {
                        
                        Console.WriteLine("makin dekat");
                    }
                }

                else if (playerTebak < randomAngka)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Kekecilan");
                    if ((randomAngka - playerTebak) <= 5 )
                    {
                        
                        Console.WriteLine("makin dekat");
                    }
                }
              
                
                percobaan += 1;
                Console.WriteLine();
            }
        }
    }
}

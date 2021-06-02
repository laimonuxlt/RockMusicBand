using System;

namespace RockMusicBand
{
    class Program
    {


        static void
            Main(string[] args)
        {

            Model model = new Model();

            PrintMenu();
           
            static void PrintMenu()
            {
                Console.WriteLine("Rock Music Band Application");
                Console.WriteLine("---------------------------");
                Console.WriteLine("Choose an option from the following list:");
                Console.WriteLine("Type 1 to generate random band name, and then press Enter ");
                Console.WriteLine("Type 2 to create your own band name, and then press Enter ");
                Console.WriteLine("Type 3 to print adjectives and noun count, and then press Enter ");
                Console.WriteLine("Type 4 to generate band members, and then press Enter ");
                Console.WriteLine("Type 5 to add adjective for band name, and then press Enter ");
                Console.WriteLine("Type 6 to add noun for band name, and then press Enter ");
                Console.WriteLine("Type 7 to print all bands and members, and then press Enter ");
                Console.WriteLine("Type q to quit, and then press Enter ");

            }

            while (true)
            {
                switch (Console.ReadLine())
                {

                    case "1":
                        model.GenerateRandomBandName();
                        break;
                    case "2":
                        model.CreateOwnBandName();
                        break;
                    case "3":
                        model.PrintAdjectivesAndNounsCount();
                        break;
                    case "4":
                        model.GenerateMembersForBand();
                        break;
                    case "5":
                        model.AddAdjectiveForBandName();
                        break;
                    case "6":
                        model.AddNounForBandName();
                        break;
                    case "7":
                        model.PrintBands();
                        break;
                    case "q":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.Clear();
                        PrintMenu();
                        break;


                }
            }

        }
    }
}

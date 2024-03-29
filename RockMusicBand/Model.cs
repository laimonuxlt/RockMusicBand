﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RockMusicBand
{
    class Model
    {
        List<BandAdjective> adjectives = new List<BandAdjective>()
        {
            new BandAdjective() { Id = 1, Adjective = "Stuning"},
            new BandAdjective() { Id = 2, Adjective = "Delightful"},
            new BandAdjective() { Id = 3, Adjective = "Wild"},
            new BandAdjective() { Id = 4, Adjective = "Useless"},
            new BandAdjective() { Id = 5, Adjective = "Great"},
            new BandAdjective() { Id = 6, Adjective = "Drunken"},
            new BandAdjective() { Id = 7, Adjective = "Crazy"},
            new BandAdjective() { Id = 8, Adjective = "Quiet"},
            new BandAdjective() { Id = 9, Adjective = "Bright"},
            new BandAdjective() { Id = 10, Adjective = "Scrumptious"}
        };


        List<BandNoun> nouns = new List<BandNoun>()
        {

            new BandNoun(){ Id = 1, Noun = "Compass"},
            new BandNoun(){ Id = 2, Noun = "Banana"},
            new BandNoun(){ Id = 3, Noun = "Geek"},
            new BandNoun(){ Id = 4, Noun = "Sausage"},
            new BandNoun(){ Id = 5, Noun = "Fairy"},
            new BandNoun(){ Id = 6, Noun = "Melons"},
            new BandNoun(){ Id = 7, Noun = "Buffalo"},
            new BandNoun(){ Id = 8, Noun = "Programmers"},
            new BandNoun(){ Id = 9, Noun = "Mustangs"},
            new BandNoun(){ Id = 10, Noun = "Joysticks"}
        };


        List<Musician> musicians = new List<Musician>()
        {
            new Musician() { Id = 1, Name = "Bodrum Salvador" },
            new Musician() { Id = 2, Name = "Hilary Ouse" },
            new Musician() { Id = 3, Name = "Indigo Violet" },
            new Musician() { Id = 4, Name = "Hans Down" },
            new Musician() { Id = 5, Name = "Shequondolisa Bivouac" },
            new Musician() { Id = 6, Name = "Ingredia Nutrisha" },
            new Musician() { Id = 7, Name = "Fig Nelson" },
            new Musician() { Id = 8, Name = "Benjamin Evalent" },
            new Musician() { Id = 9, Name = "Gustav Purpleson" },
            new Musician() { Id = 10, Name = "Elon Gated" },
        };



        List<Band> bands = new List<Band>();

        List<BandMember> bandMembers = new List<BandMember>();

        readonly string[] role = { "Vocals", "Bass", "Guitar", "Drumms" };






        public void PrintAdjectivesAndNounsCount()
        {
            int numberOfAdjectives = adjectives.Count;
            int numberOfNouns = nouns.Count;
            Console.WriteLine($"Total number of  adjectives: { numberOfAdjectives}");
            Console.WriteLine($"Total number of  nouns: {numberOfNouns}");
            PrintSelectionLine();
        }

        public void GenerateRandomBandName()
        {
            Random randomForAjective = new Random();
            var randomAdjectiveIndex = randomForAjective.Next(1, adjectives.Count);
            var randomAdjective = adjectives.FirstOrDefault(n => n.Id == randomAdjectiveIndex);


            Random randomForNoun = new Random();
            var randomNounIndex = randomForNoun.Next(1, adjectives.Count);
            var randomNoun = nouns.FirstOrDefault(n => n.Id == randomNounIndex);

            string bandName = $"{randomAdjective.Adjective} {randomNoun.Noun}";


            int bandId = 0;
            if (bands.Count == 0)
            {
                bandId += 1;
            }
            else
            {
                var numberOfBands = bands.Max(n => n.Id);
                bandId = numberOfBands + 1;
            }


            bands.Add(new Band { Id = bandId, BandName = bandName });

            Console.WriteLine($"You have created random band name: {bandName}");
            PrintSelectionLine();
        }


        public void CreateOwnBandName()
        {
            Console.WriteLine("Type the number of adjective you like, and press enter");

            foreach (BandAdjective adjective in adjectives)
            {
                Console.WriteLine($"{adjective.Id} {adjective.Adjective}");
            }

            var adjectiveChoiceString = Console.ReadLine();
            var adjectiveChoiceNumber = Convert.ToInt32(adjectiveChoiceString);
            var adjectiveChoice = adjectives.FirstOrDefault(n => n.Id == adjectiveChoiceNumber);

            Console.WriteLine("Now type the number of noun you like, and press Enter");

            foreach (BandNoun noun in nouns)
            {
                Console.WriteLine($"{noun.Id} {noun.Noun}");
            }

            var nounChoiceString = Console.ReadLine();
            var nounChoiceNumber = Convert.ToInt32(nounChoiceString);
            var nounChoice = nouns.FirstOrDefault(n => n.Id == nounChoiceNumber);

            string bandName = $"{adjectiveChoice.Adjective} {nounChoice.Noun}";

            int bandId = 0;
            if (bands.Count == 0)
            {
                bandId += 1;
            }
            else
            {
                var numberOfBands = bands.Max(n => n.Id);
                bandId = numberOfBands + 1;
            }

            bands.Add(new Band { Id = bandId, BandName = bandName });

            Console.WriteLine($"You have created the band named: {bandName}");
            PrintSelectionLine();
        }



        public void AddAdjectiveForBandName()
        {

            Console.WriteLine("Please enter your adjective: ");
            var adjectiveOwn = Console.ReadLine();

            var numberOfAdjectives = adjectives.Max(n => n.Id);
            var newAdjectiveId = numberOfAdjectives + 1;


            adjectives.Add(new BandAdjective { Id = newAdjectiveId, Adjective = adjectiveOwn });

            Console.WriteLine($"You added adjective {adjectiveOwn}");
            PrintSelectionLine();
        }

        public void AddNounForBandName()
        {

            Console.WriteLine("Please enter your noun ");
            var nounOwn = Console.ReadLine();

            var numberOfNouns = nouns.Max(n => n.Id);
            var newNounId = numberOfNouns + 1;

            nouns.Add(new BandNoun { Id = newNounId, Noun = nounOwn });

            Console.WriteLine($"You added noun: {nounOwn}");
            PrintSelectionLine();
        }

        public void GenerateMembersForBand()
        {

            Console.WriteLine("Select the band from list end enter its number:");

            if (bands.Count == 0)
            {
                Console.WriteLine("No bands in database exist");
                PrintSelectionLine();
            }
            else
            {
                foreach (Band band in bands)
                {
                    Console.WriteLine($"{band.Id} { band.BandName}");

                }

                var selectedBand = Console.ReadLine();
                var selectedBandNumber = Convert.ToInt32(selectedBand);
                var bandChoice = bands.SingleOrDefault(n => n.Id == selectedBandNumber);
                string bandName = $"{bandChoice.BandName}";



                Console.WriteLine("Generated band members:");
                for (int i = 0; i < role.Length; i++)
                {
                    var randomForName = new Random();
                    var randomNameIndex = randomForName.Next(1, musicians.Count);
                    var randomName = musicians.SingleOrDefault(n => n.Id == randomNameIndex);
                    string memberName = randomName.Name;
                    Console.WriteLine($"{role[i]}: {memberName}");
                    bandMembers.Add(new BandMember { BandName = bandName, MemberName = memberName, Role = role[i] });
                }

                PrintSelectionLine();
            }
        }

        public void PrintBands()
        {

            Console.WriteLine("Generated bands with members:");
            if (bandMembers.Count == 0)
            {
                Console.WriteLine("No bands with members in database");
            }
            else
            {
                foreach (BandMember bandMember in bandMembers)
                {

                    Console.WriteLine($"{bandMember.BandName}: {bandMember.MemberName} {bandMember.Role}");

                }
            }

            PrintSelectionLine();
        }

        public void PrintSelectionLine()
        {
            Console.WriteLine("---------------------------");
            Console.WriteLine("Please select an option from the menu");
        }
    }
}

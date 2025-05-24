using System;

// #1 the ourAnimals array will store the following: 
string animalSpecies = "";
string animalID = "";
string animalAge = "";
string animalPhysicalDescription = "";
string animalPersonalityDescription = "";
string animalNickname = "";
string suggestedDonation = "";

// #2 variables that support data entry
int maxPets = 8;
string? readResult;
string menuSelection = "";
decimal decimalDonation = 0.00m;

// #3 array used to store runtime data, there is no persisted data
string[,] ourAnimals = new string[maxPets, 7];

// #4 create sample data ourAnimals array entries
for (int i = 0; i < maxPets; i++)
{
    switch (i)
    {
        case 0:
            animalSpecies = "dog";
            animalID = "d1";
            animalAge = "2";
            animalPhysicalDescription = "medium sized cream colored female golden retriever weighing about 45 pounds. housebroken.";
            animalPersonalityDescription = "loves to have her belly rubbed and likes to chase her tail. gives lots of kisses.";
            animalNickname = "lola";
            suggestedDonation = "85.00";
            break;

        case 1:
            animalSpecies = "dog";
            animalID = "d2";
            animalAge = "9";
            animalPhysicalDescription = "large reddish-brown male golden retriever weighing about 85 pounds. housebroken.";
            animalPersonalityDescription = "loves to have his ears rubbed when he greets you at the door, or at any time! loves to lean-in and give doggy hugs.";
            animalNickname = "gus";
            suggestedDonation = "49.99";
            break;

        case 2:
            animalSpecies = "cat";
            animalID = "c3";
            animalAge = "1";
            animalPhysicalDescription = "small white female weighing about 8 pounds. litter box trained.";
            animalPersonalityDescription = "friendly";
            animalNickname = "snow";
            suggestedDonation = "40.00";
            break;

        case 3:
            animalSpecies = "cat";
            animalID = "c4";
            animalAge = "3";
            animalPhysicalDescription = "Medium sized, long hair, yellow, female, about 10 pounds. Uses litter box.";
            animalPersonalityDescription = "A people loving cat that likes to sit on your lap.";
            animalNickname = "Lion";
            suggestedDonation = "";
            break;

        default:
            animalSpecies = "";
            animalID = "";
            animalAge = "";
            animalPhysicalDescription = "";
            animalPersonalityDescription = "";
            animalNickname = "";
            suggestedDonation = "";
            break;
    }

    // Validate and process suggested donation
    if (!decimal.TryParse(suggestedDonation, out decimalDonation))
    {
        decimalDonation = 45.00m; // if suggestedDonation NOT a number, default to 45.00
    }

    ourAnimals[i, 0] = "ID #: " + animalID;
    ourAnimals[i, 1] = "Species: " + animalSpecies;
    ourAnimals[i, 2] = "Age: " + animalAge;
    ourAnimals[i, 3] = "Nickname: " + animalNickname;
    ourAnimals[i, 4] = "Physical description: " + animalPhysicalDescription;
    ourAnimals[i, 5] = "Personality: " + animalPersonalityDescription;
    ourAnimals[i, 6] = $"Suggested Donation: {decimalDonation:C2}";
}

// #5 display the top-level menu options
do
{
    Console.Clear();
    Console.WriteLine("Welcome to the Contoso PetFriends app. Your main menu options are:");
    Console.WriteLine(" 1. List all of our current pet information");
    Console.WriteLine(" 2. Display all dogs with a specified characteristic");
    Console.WriteLine();
    Console.WriteLine("Enter your selection number (or type Exit to exit the program)");

    readResult = Console.ReadLine();
    if (readResult != null)
    {
        menuSelection = readResult.ToLower();
    }

    switch (menuSelection)
    {
        case "1":
            // list all pet info
            for (int i = 0; i < maxPets; i++)
            {
                if (ourAnimals[i, 0] != "ID #: ")
                {
                    Console.WriteLine();
                    for (int j = 0; j < 7; j++)
                    {
                        Console.WriteLine(ourAnimals[i, j]);
                    }
                }
            }
            Console.WriteLine("\n\rPress the Enter key to continue");
            readResult = Console.ReadLine();
            break;

        case "2":
            // #1 Display all dogs with multiple specified characteristics
            string dogCharacteristics = "";
            string dogDescription = "";
            bool noMatchesDog = true;

            // #1 Gather user input for multiple search terms
            while (dogCharacteristics == "")
            {
                Console.WriteLine($"\nEnter dog characteristics to search for separated by commas");
                readResult = Console.ReadLine();
                if (readResult != null)
                {
                    dogCharacteristics = readResult.ToLower().Trim();
                }
            }

            // #2 Store search terms in array and sort alphabetically  
            string[] dogSearches = dogCharacteristics.Split(',');
            for (int i = 0; i < dogSearches.Length; i++)
            {
                dogSearches[i] = dogSearches[i].Trim();
            }
            Array.Sort(dogSearches);

            // #4 Updated animation icons for spinning effect
            string[] searchingIcons = {"|", "/", "-", "\\", "*", ".", "o", "0", "O", "o"};

            // #3 loop through the ourAnimals array to search for matching animals
            for (int i = 0; i < maxPets; i++)
            {
                if (ourAnimals[i, 1].Contains("dog"))
                {
                    // Get the dog's nickname for display
                    string dogNickname = ourAnimals[i, 3].Replace("Nickname: ", "");
                    
                    // Get combined description
                    dogDescription = ourAnimals[i, 4] + "\n" + ourAnimals[i, 5];
                    
                    bool dogMatched = false;

                    // #3 Search each term for current dog
                    foreach (string term in dogSearches)
                    {
                        // #4 & #5 Animation with countdown
                        for (int k = 2; k >= 0; k--)
                        {
                            foreach (string icon in searchingIcons)
                            {
                                Console.Write($"\rsearching our dog {ourAnimals[i, 3]} for {term} {icon} {k}");
                                Thread.Sleep(100);
                            }
                        }

                        // Clear the searching line
                        Console.Write("\r" + new string(' ', Console.WindowWidth - 1) + "\r");

                        if (dogDescription.Contains(term))
                        {
                            Console.WriteLine($"Our dog {ourAnimals[i, 3]} matches your search for {term}");
                            noMatchesDog = false;
                            dogMatched = true;
                        }
                    }

                    // If dog had any matches, display its info
                    if (dogMatched)
                    {
                        Console.WriteLine($"{ourAnimals[i, 3]} ({ourAnimals[i, 0]})");
                        Console.WriteLine(ourAnimals[i, 4]);
                        Console.WriteLine(ourAnimals[i, 5]);
                        Console.WriteLine();
                    }
                }
            }

            if (noMatchesDog)
            {
                Console.WriteLine($"None of our dogs are a match for: {dogCharacteristics}");
                Console.WriteLine();
            }

            Console.WriteLine("Press the Enter key to continue");
            readResult = Console.ReadLine();
            break;

        default:
            break;
    }

} while (menuSelection != "exit");
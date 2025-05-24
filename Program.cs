using System;


// 18 different species at the Contoso Petting Zoo
string[] pettingZoo = 
{
    "alpacas", "capybaras", "chickens", "ducks", "emus", "geese", 
    "goats", "iguanas", "kangaroos", "lemurs", "llamas", "macaws", 
    "ostriches", "pigs", "ponies", "rabbits", "sheep", "tortoises",
};

// Plan visits for three schools with different group sizes
Console.WriteLine("=== CONTOSO PETTING ZOO VISIT COORDINATOR ===\n");

PlanSchoolVisit("School A");        // Default 6 groups
PlanSchoolVisit("School B", 3);     // 3 groups
PlanSchoolVisit("School C", 2);     // 2 groups

/// <summary>
/// Orchestrates complete school visit planning process
/// </summary>
/// <param name="schoolName">Name of the visiting school</param>
/// <param name="groups">Number of student groups (default: 6)</param>
void PlanSchoolVisit(string schoolName, int groups = 6) 
{
    RandomizeAnimals(); 
    string[,] groupAssignments = AssignGroup(groups);
    Console.WriteLine($"🏫 {schoolName}");
    PrintGroup(groupAssignments);
    Console.WriteLine(); // Add spacing between schools
}

/// <summary>
/// Randomizes the petting zoo animals using Fisher-Yates shuffle algorithm
/// Ensures fair distribution and unique experience for each school visit
/// </summary>
void RandomizeAnimals() 
{
    Random random = new Random();

    // Fisher-Yates shuffle: iterate through array and swap each element 
    // with a randomly selected element from remaining unshuffled portion
    for (int i = 0; i < pettingZoo.Length; i++) 
    {
        // Select random index from current position to end of array
        int randomIndex = random.Next(i, pettingZoo.Length);

        // Swap current element with randomly selected element
        string temp = pettingZoo[randomIndex];
        pettingZoo[randomIndex] = pettingZoo[i];
        pettingZoo[i] = temp;
    }
}

/// <summary>
/// Assigns randomized animals to specified number of groups
/// </summary>
/// <param name="groups">Number of groups to create (default: 6)</param>
/// <returns>2D array containing group assignments [groups, animals per group]</returns>
string[,] AssignGroup(int groups = 6) 
{
    // Calculate animals per group: 18 animals divided by number of groups
    int animalsPerGroup = pettingZoo.Length / groups;
    
    // Create 2D array: [number of groups] x [animals per group]
    string[,] result = new string[groups, animalsPerGroup];
    int animalIndex = 0;

    // Assign animals to groups sequentially after randomization
    for (int group = 0; group < groups; group++) 
    {
        for (int position = 0; position < animalsPerGroup; position++) 
        {
            result[group, position] = pettingZoo[animalIndex++];
        }
    }

    return result;
}

/// <summary>
/// Displays formatted group assignments with group numbers and animal lists
/// </summary>
/// <param name="groups">2D array containing group assignments</param>
void PrintGroup(string[,] groups) 
{
    // Iterate through each group (rows)
    for (int group = 0; group < groups.GetLength(0); group++) 
    {
        Console.Write($"   Group {group + 1}: ");
        
        // Print all animals in current group (columns)
        for (int animal = 0; animal < groups.GetLength(1); animal++) 
        {
            Console.Write($"{groups[group, animal]}  ");
        }
        Console.WriteLine(); // New line after each group
    }
}
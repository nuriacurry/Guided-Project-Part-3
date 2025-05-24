# CSC 350H Homework 2b - Contoso Pets Application

## Project Overview
Complete Guided and Challenge Project of Microsoft Learn C# Part 3 and 4 for CSC 350H under Professor Hao Tang's guidance.

## Description
This project implements a pet management console application that helps place pets in new homes. The application demonstrates the use of boolean expressions, selection statements, and iteration statements.

## Features Implemented

### Phase 1: Guided Project Part 3
- ✅ Menu system with 8 options
- ✅ Sample data generation using switch-case
- ✅ Display all pet information (Menu Option 1)
- ✅ Add new animals with data validation (Menu Option 2)
- ✅ Proper looping and input validation
- ✅ Pet counting and capacity management

### Phase 2: Challenge Project Part 3 (Coming Soon)
- 🔄 Ensure animal ages and physical descriptions are complete (Menu Option 3)
- 🔄 Ensure animal nicknames and personality descriptions are complete (Menu Option 4)

### Phase 3: Guided Project Part 4 (Coming Soon)
- 🔄 Edit an animal's age (Menu Option 5)
- 🔄 Edit an animal's personality description (Menu Option 6)

### Phase 4: Challenge Project Part 4 (Coming Soon)
- 🔄 Display all cats with specified characteristics (Menu Option 7)
- 🔄 Display all dogs with specified characteristics (Menu Option 8)

## Data Structure
- Multidimensional string array `ourAnimals[8,6]`
- Stores: Pet ID, Species, Age, Nickname, Physical Description, Personality
- Maximum capacity: 8 pets

## Usage
1. Run: `dotnet run`
2. Select menu options 1-8 or type 'exit'
3. Follow prompts for data entry and validation

## Requirements
- .NET Core/Framework
- Visual Studio Code
- C# language support

## Development Progress
- **Guided Project Part 3**: ✅ Complete (Menu Options 1-2)
- **Challenge Project Part 3**: ✅ Complete (Menu Options 3-4)
- **Guided Project Part 4**: ✅ Complete (Menu Options 5-6)
- **Challenge Project Part 4**: ✅ Complete (Menu Options 7-8)

## Git Workflow
Each major milestone will be committed with meaningful messages tracking progress through the Microsoft Learn modules.

# CSC 350H Homework 3.2 - Contoso Petting Zoo Application

## Project Overview
**Added to Homework 2 Repository:** Guided Project Part 5 - Methods with Optional Parameters and Return Values

This application coordinates school visits to the Contoso Petting Zoo, managing student groups and animal assignments for an optimal educational experience.

## Application Features

### Core Functionality
- **18 Animal Species:** Complete petting zoo with diverse animals
- **Flexible Group Sizing:** Supports 2-6 groups based on school size
- **Randomized Experience:** Each visit has unique animal-group assignments
- **Three School Types:**
  - School A: 6 groups (default)
  - School B: 3 groups  
  - School C: 2 groups

### Method Implementation

#### `PlanSchoolVisit(string schoolName, int groups = 6)`
- **Purpose:** Orchestrates complete visit planning process
- **Parameters:** School name (required), number of groups (optional, default: 6)
- **Process:** Randomizes animals → Assigns groups → Displays results

#### `RandomizeAnimals()`
- **Algorithm:** Fisher-Yates shuffle for optimal randomization
- **Purpose:** Ensures unique experience for each school visit
- **Implementation:** Swaps each element with randomly selected element from remaining array

#### `AssignGroup(int groups = 6)`
- **Return Type:** `string[,]` (2D array)
- **Optional Parameter:** `groups` with default value of 6
- **Logic:** Distributes 18 animals evenly across specified number of groups
- **Array Structure:** `[groups, pettingZoo.Length/groups]`

#### `PrintGroup(string[,] groups)`
- **Purpose:** Displays formatted group assignments
- **Format:** "Group X: animal1 animal2 animal3..."
- **Implementation:** Nested loops through 2D array dimensions

## Technical Implementation

### Data Structures
- **Global Array:** `string[] pettingZoo` with 18 animal species
- **2D Array:** Dynamic group assignments based on visit requirements
- **Random Object:** Ensures truly random animal distribution

### Method Design Patterns
- **Optional Parameters:** Default group size with flexibility for variation
- **Return Values:** Methods return processed data for modular design
- **Separation of Concerns:** Each method handles specific responsibility
- **Global Variable Access:** Efficient use of shared pettingZoo array

### Algorithm Efficiency
- **Fisher-Yates Shuffle:** O(n) time complexity for optimal randomization
- **Sequential Assignment:** O(n) time for group distribution
- **Display Logic:** O(groups × animals_per_group) for output formatting

## Sample Output
```
=== CONTOSO PETTING ZOO VISIT COORDINATOR ===

🏫 School A
   Group 1: kangaroos  lemurs  pigs  
   Group 2: alpacas  sheep  chickens  
   Group 3: ducks  geese  capybaras  
   Group 4: ponies  iguanas  tortoises  
   Group 5: ostriches  llamas  rabbits  
   Group 6: macaws  goats  emus  

🏫 School B
   Group 1: llamas  ducks  ponies  geese  chickens  goats  
   Group 2: iguanas  capybaras  macaws  kangaroos  rabbits  sheep  
   Group 3: lemurs  tortoises  alpacas  pigs  emus  ostriches  

🏫 School C
   Group 1: sheep  ducks  pigs  macaws  kangaroos  ostriches  rabbits  goats  lemurs  
   Group 2: iguanas  capybaras  chickens  emus  tortoises  geese  ponies  alpacas  llamas  
```

## Educational Objectives Met
- ✅ **Method Definition:** Multiple methods with clear purposes
- ✅ **Optional Parameters:** Default values with override capability
- ✅ **Return Values:** Methods return processed data
- ✅ **Parameter Passing:** String and integer parameters
- ✅ **Array Manipulation:** 1D and 2D array operations
- ✅ **Algorithm Implementation:** Fisher-Yates shuffle
- ✅ **Code Organization:** Modular, reusable method design

## Development Process
1. **Pseudo-code Planning:** Mapped requirements to method signatures
2. **Incremental Implementation:** Built and tested each method individually
3. **Integration Testing:** Verified complete workflow functionality
4. **Code Refinement:** Added documentation and optimized algorithms

## Usage Instructions
```bash
# Run the application
dotnet run

# Expected behavior:
# - Displays three schools with different group configurations
# - Animals are randomly distributed for each school
# - Each school shows appropriate number of groups
# - Format is clean and readable
```

## Git Workflow Integration
- **Branch:** `guided-project-part5` 
- **Commit Strategy:** One commit per tutorial unit
- **Documentation:** Comprehensive README updates
- **Code Quality:** Professional documentation and structure

## Author
**Student:** Nuria Siddiqa
**Professor:** Hao Tang
**Institution:** Course work following Microsoft Learn C# curriculum
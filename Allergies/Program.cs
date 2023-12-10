// using System;
// using Allergies.Models;
// using System.Collections.Generic;

// namespace Allergies.Models
// {
//     public class Program
//     {
//         static void Main()
//         {
//             Console.WriteLine("Allergen Determiner");
//             Console.WriteLine();
//             Console.WriteLine();
//             Console.WriteLine("Enter the allergy score:");

//         if (int.TryParse(Console.ReadLine(), out int allergyScore))
//         {
//             MyAllergies allergens = new MyAllergies(allergyScore);
            
//             // Print Allergies list
//             List<string> listOfAllergens = allergens.DetermineAllergen();
//             foreach (string item in listOfAllergens)
//             {
//                 Console.WriteLine($"You are allergic to: {item}");
//             }

//             Console.WriteLine("Would you like to go again? enter 'y' for yes and 'n' for no");
//             string userContinue = Console.ReadLine().ToLower();

//             switch (userContinue)
//             {
//                 case "y":
//                     Console.WriteLine();
//                     Console.WriteLine();
//                     Console.WriteLine("Lets go again");
//                     break;
//                 case "n":
//                     Console.WriteLine();
//                     Console.WriteLine();
//                     Console.WriteLine("Goodbye");
//                     break;
//                 default:
//                     Console.WriteLine();
//                     Console.WriteLine("Sorry, I didn't get that, lets give it another try");
//                     Main();
//                     break;
//             }
            
//         }
//         else
//         {
//             Console.WriteLine("Invalid input. Please enter a valid integer for the allergy score.");
//         }






//         //     Console.WriteLine("Allergen Determiner");
//         //     Console.WriteLine();
//         //     Console.WriteLine();
//         //     Console.WriteLine("Enter the allergy score:");

//         // if (int.TryParse(Console.ReadLine(), out int allergyScore))
//         // {
//         //     MyAllergies analyzer = new MyAllergies();
//         //     string detectedAllergens = analyzer.DetermineAllergen(allergyScore);

//         //     Console.WriteLine($"Detected allergens: {detectedAllergens}");
//         // }
//         // else
//         // {
//         //     Console.WriteLine("Invalid input. Please enter a valid integer for the allergy score.");
//         // }
//         }      
//     }
// }
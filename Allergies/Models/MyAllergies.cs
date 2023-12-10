using System;
using System.Collections.Generic;

namespace Allergies.Models
{
    public class MyAllergies
    {
        /*
                allergen     score
                eggs         1
                peanuts      2
                shellfish    4
                strawberries 8
                tomatoes     16
                chocolate    32
                pollen       64
                cats         128
                */
               
        // when we run MyAllergies(3)... It should print a list of a person's allergies: which is eggs and peanuts


        public int AllergyScore { get; set; }

        private static List<string> _allergyList = new List<string>(){};

        // The constructor
        public MyAllergies(int MyAllergyScore)
        {
            AllergyScore = MyAllergyScore;
        }

        public List<string> DetermineAllergen()
        {
            if (AllergyScore == 0)
            {
                _allergyList.Add("You have no allergies");
            }
            if (AllergyScore >= 128)
            {
                _allergyList.Add("cats");
                _allergyList.Add("pollen");
                _allergyList.Add("chocolate");
                _allergyList.Add("tomatoes");
                _allergyList.Add("strawberries");
                _allergyList.Add("shellfish");
                _allergyList.Add("peanuts");
                _allergyList.Add("eggs");
            }
            else if (AllergyScore >= 64)
            {
                _allergyList.Add("pollen");
                _allergyList.Add("chocolate");
                _allergyList.Add("tomatoes");
                _allergyList.Add("strawberries");
                _allergyList.Add("shellfish");
                _allergyList.Add("peanuts");
                _allergyList.Add("eggs");
            }
            else if (AllergyScore >= 32)
            {
                _allergyList.Add("chocolate");
                _allergyList.Add("tomatoes");
                _allergyList.Add("strawberries");
                _allergyList.Add("shellfish");
                _allergyList.Add("peanuts");
                _allergyList.Add("eggs");
            }
            else if (AllergyScore >= 16)
            {
                _allergyList.Add("tomatoes");
                _allergyList.Add("strawberries");
                _allergyList.Add("shellfish");
                _allergyList.Add("peanuts");
                _allergyList.Add("eggs");
            }
            else if (AllergyScore >= 8)
            {
                _allergyList.Add("strawberries");
                _allergyList.Add("shellfish");
                _allergyList.Add("peanuts");
                _allergyList.Add("eggs");
            }
            else if (AllergyScore >= 4)
            {
                _allergyList.Add("shellfish");
                _allergyList.Add("peanuts");
                _allergyList.Add("eggs");
            }
            else if (AllergyScore >= 2)
            {
                _allergyList.Add("peanuts");
                _allergyList.Add("eggs");
            }
            else if (AllergyScore >= 1)
            {
                _allergyList.Add("eggs");
            }
            return _allergyList;
        }








        // With the code above: DetermineAllergen method now correctly adds instances of MyAllergies to the _arrayAllergen list based on the provided allergy score 

        // this method is unnecessary, as you already have the _arrayAllergen field that can be accessed directly.
        // public List<MyAllergies> GetAllAllergenScore()
        // {
        //     return _arrayAllergen;
        // }
        
/*
        public string DetermineAllergen(int score)
        {
        Dictionary<int, string> listOfAllergens = new Dictionary<int, string>() {
            {128, "Cats"},
            {64, "Pollen"},
            {32, "Chocolate"},
            {16, "Tomatoes"},
            {8, "Strawberries"},
            {4, "Shellfish"},
            {2, "Peanuts"},
            {1, "Egg"}
        };

        List<string> outputList = new List<string> { };
        foreach (var allergen in listOfAllergens)
        {
            // Console.WriteLine(allergen.Key);
            // Console.WriteLine(allergen.Value);
            if (score >= allergen.Key)
            {
            outputList.Add(allergen.Value);
            score -= allergen.Key;
            }
        }
        return String.Join(", ", outputList.ToArray());
        }
*/
        

    }
}
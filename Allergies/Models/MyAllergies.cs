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


        // The constructor
        public MyAllergies(int MyAllergyScore)
        {
            AllergyScore = MyAllergyScore;
        }

        List<string> _arrayAllergen = new List<string>();

        // Determine allergen... This will be a recursive method; I will call it within itself
        public string[] DetermineAllergen()
        {
            // For eggs
            if(AllergyScore == 3)
            {
                return _arrayAllergen.Add("eggs");
            }

        }


        
        

    }
}
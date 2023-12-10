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


        // Allergen scores
        public const int Eggs = 1;
        public const int Peanuts = 2;
        public const int Shellfish = 4;
        public const int Strawberries = 8;
        public const int Tomatoes = 16;
        public const int Chocolate = 32;
        public const int Pollen = 64;
        public const int Cats = 128;

        public int AllergyScore { get; set; }

        private static List<MyAllergies> _arrayAllergen = new List<MyAllergies>();

        // The constructor
        public MyAllergies(int MyAllergyScore)
        {
            AllergyScore = MyAllergyScore;
            _arrayAllergen.Add(this);
        }


        // Determine allergen... This will be a recursive method; I will call it within itself
        public void DetermineAllergen()
        {
            DetermineAllergenRecursively(AllergyScore);
        }


        private void DetermineAllergenRecursively(int remainingScore)
        {
            // Check if the remaining score is greater than or equal to a specific allergen score
            if (remainingScore >= Cats)
            {
                _arrayAllergen.Add(new MyAllergies(Cats));
                remainingScore -= Cats;
            }
            else if (remainingScore >= Pollen)
            {
                _arrayAllergen.Add(new MyAllergies(Pollen));
                remainingScore -= Pollen;
            }
            else if (remainingScore >= Chocolate)
            {
                _arrayAllergen.Add(new MyAllergies(Chocolate));
                remainingScore -= Chocolate;
            }
            else if(remainingScore >= Tomatoes)
            {
                _arrayAllergen.Add(new MyAllergies(Tomatoes));
                remainingScore -= Tomatoes;
            }
            else if(remainingScore >= Strawberries)
            {
                _arrayAllergen.Add(new MyAllergies(Strawberries));
                remainingScore -= Strawberries;
            }
            else if(remainingScore >= Shellfish)
            {
                _arrayAllergen.Add(new MyAllergies(Shellfish));
                remainingScore -= Shellfish;
            }
            else if(remainingScore >= Peanuts)
            {
                _arrayAllergen.Add(new MyAllergies(Peanuts));
                remainingScore -= Peanuts;
            }
            else if(remainingScore >= Eggs)
            {
                _arrayAllergen.Add(new MyAllergies(Eggs));
                remainingScore -= Eggs;
            }
        }

        public List<MyAllergies> GetAllAllergenInstances()
        {
            return _arrayAllergen;
        }

        // With the code above: DetermineAllergen method now correctly adds instances of MyAllergies to the _arrayAllergen list based on the provided allergy score 

        // this method is unnecessary, as you already have the _arrayAllergen field that can be accessed directly.
        // public List<MyAllergies> GetAllAllergenScore()
        // {
        //     return _arrayAllergen;
        // }
        


        
        

    }
}
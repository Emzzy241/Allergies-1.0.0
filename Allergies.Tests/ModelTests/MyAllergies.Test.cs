using Microsoft.VisualStudio.TestTools.UnitTesting;
using Allergies.Models;
using System.Collections.Generic;
using System;


namespace Allergies.Tests
{
    [TestClass]
    public class MyAllergiesTests
    {
        // 1st Test: Test to create an instance of MyAllergies class
        [TestMethod]
        public void MyAllergiesConstructor_CreatesInstanceOfMyAllergiesClass_MyAllergies()
        {
            MyAllergies newAllergy = new MyAllergies(3);
            Assert.AreEqual(typeof(MyAllergies), newAllergy.GetType());
        }

        // 2nd Test: Getting the allergy score
        [TestMethod]
        public void GetAllergyScore_GetsTheAllergyScore_Int()
        {
            // Arrange
            MyAllergies newAllergy = new MyAllergies(3);
            int expectedAllergyScore = 3;

            // Act
            int returnedAllergyScore = newAllergy.AllergyScore;

            // Assert
            Assert.AreEqual(expectedAllergyScore, returnedAllergyScore);
        }
        
        // 3rd Test: setting the allergy score
        [TestMethod]
        public void SetAllergyScore_SetsTheAllergyScore_Int()
        {
            // Arrange
            MyAllergies newAllergy = new MyAllergies(3);
            int newAllergyScore = 7;

            // Act
            newAllergy.AllergyScore = newAllergyScore;

            // Assert
            Assert.AreEqual(newAllergyScore, newAllergy.AllergyScore);
        }

        // [TestMethod]
        // public void DetermineAllergen_DetermineWhichAllergen_Void()
        // {
        //     // Arrange 
        //     MyAllergies personAllergies = new MyAllergies(3);

        //     // Act
        //     personAllergies.DetermineAllergen();

        //     // Assert
        //     Assert.AreEqual(expectedList, )
        // }

        [TestMethod]
        public void DetermineAllergen_ShouldAddCorrectAllergensToList()
        {
            // Arrange
            MyAllergies personAllergies = new MyAllergies(35); // Example score, you can use any valid score

            // Act
            personAllergies.DetermineAllergen();
            List<MyAllergies> allergenInstances = personAllergies.GetAllAllergenInstances();



            // Assert
            Assert.IsTrue(allergenInstances.Count > 0);

            //  the assertion is checking if there is at least one element in the allergenInstances list with an AllergyScore equal to MyAllergies.Chocolate. If such an element exists, the assertion passes; otherwise, it fails.

            // Add specific assertions based on your scoring logic
            // Assert.IsTrue(allergenInstances.Exists(a => a.AllergyScore == MyAllergies.Eggs));
            Assert.IsTrue(allergenInstances.Exists(a => a.AllergyScore == MyAllergies.Chocolate));
            // Add more assertions for other allergens...
            
            
            
            
            
            // // Debugging
            // foreach (var allergenInstance in allergenInstances)
            // {
            //     Console.WriteLine($"Allergen Score: {allergenInstance.AllergyScore}");
            // }

            // // Assert
            // Assert.IsTrue(allergenInstances.Exists(a => a.AllergyScore == MyAllergies.Peanuts), "Peanuts allergy should be present");
        }

        
        
    }
}
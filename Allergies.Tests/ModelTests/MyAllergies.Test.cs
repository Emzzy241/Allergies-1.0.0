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

        // [TestMethod]
       

        
        
    }
}
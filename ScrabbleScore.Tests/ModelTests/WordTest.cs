using Microsoft.VisualStudio.TestTools.UnitTesting;
using Scrabble;
using System;
using System.Collections.Generic;

namespace Scrabble.Tests
{
  [TestClass]
  public class WordTests
  {

    [TestMethod]
    public void WordConstructor_CreatesInstanceOfWord_Word()
    {
      Word newWord = new Word("test");
      Assert.AreEqual(typeof(Word), newWord.GetType());
    }

    [TestMethod]
    public void WordConstructor_SetsWordFieldInWordConstructor_Word()
    {
      //Arrange
      string wordTest = "balloon";

      //Act
      Word testWord = new Word(wordTest);

      //Assert
      Assert.AreEqual(testWord.TheWord, wordTest);
    }

  }
}

// Test boilerplate
// [TestMethod]
// public void NameOfMethodWeAreTesting_DescriptionOfBehavior_ExpectedReturnValue()
// {
//   // any necessary logic to prep for test; instantiating new classes, etc.
//   Assert.AreEqual(EXPECTED RESULT, CODE TO TEST);
// }
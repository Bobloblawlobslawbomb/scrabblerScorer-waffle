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
    //test2 and test3 are essentially the same
    {
      //Arrange
      string wordTest = "balloon";

      //Act
      Word testWord = new Word(wordTest);

      //Assert
      Assert.AreEqual(testWord.TheWord, wordTest);
    }

    [TestMethod]
    public void GetWord_ReturnsTheWord_string()
    //test2 and test3 are essentially the same
    {
      //Arrange
      string wordTest = "quirky";
      Word testWord = new Word(wordTest);

      //Act
      string result = testWord.TheWord;

      //Assert
      Assert.AreEqual(wordTest, result);
    }

    [TestMethod]
    public void WordArrayThang_BreakTheWordIntoAnArray_Array()
    {
      //Arrange
      string wordTest = "quirky";
      char[] output = { 'q', 'u', 'i', 'r', 'k', 'y' };
      Word testWord = new Word(wordTest);

      //Act
      char[] result = testWord.WordArrayThang(wordTest);

      //Assert
      CollectionAssert.AreEqual(output, result);
    }

    [TestMethod]
    public void ScoreAssign_AddScoreForAletter_Score()
    {
      //Arrange
      string letterTest = "z";
      Word letterWord = new Word(letterTest);
      char[] resultArray = letterWord.WordArrayThang(letterWord.TheWord);
      int letterScore = 10;

      //Act
      int resultScore = letterWord.ScoreAssign(resultArray[0]);

      //Assert
      Assert.AreEqual(letterScore, resultScore);
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
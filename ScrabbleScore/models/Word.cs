using System;
using System.Collections.Generic;

namespace Scrabble
{
  public class Word
  {
    public string TheWord { get; set; }

    public Word(string theWord)
    {
      TheWord = theWord;
    }

    public char[] WordArrayThang(string thing)
    {
      return thing.ToCharArray();
    }

    public int ScoreAssign(char[] letters)
    {
      // instantiate key array for scores
      // loop that compares the input letter to the key array and increments a score variable
      // return the int value once the loop is complete
      char[] worthTen = { 'q', 'z' };
      int score = 0;
      int i = 0;

      // wrap the loop starting on line 30 in another loop that  
      // iterates through the input character array and returns
      // the value at the index
      for (i = 0; i < worthTen.Length; i++)
        if (letters[i] == worthTen[i])
        {
          score = score + 10;
        }
      return score;
    }

  }

}
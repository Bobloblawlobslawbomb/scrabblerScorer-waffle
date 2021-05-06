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

    public int ScoreAssign(char letter)
    {
      // instantiate key array for scores
      // loop that compares the input letter to the key array and increments a score variable
      // return the int value once the loop is complete
      char[] worthTen = { 'q', 'z' };
      int score = 0;
      int i = 0;

      for (i = 0; i < worthTen.Length; i++)
        // in JS, we could use Array.includes() to see if an element is there
        if (letter == worthTen[i])
        {
          score = score + 10;
        }
      return score;
    }

  }

}
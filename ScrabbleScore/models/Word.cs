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
      return letter;
    }

  }

}
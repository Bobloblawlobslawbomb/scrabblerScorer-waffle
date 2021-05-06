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
      int k = 0;

      // wrap the loop starting on line 30 in another loop that  
      // iterates through the input character array and returns
      // the value at the index
      // char[] quirkArray = { 'q', 'u', 'i', 'r', 'k', 'y' };
      // char[] worthTen = { 'q', 'z' };

      //function checkWorthTen
      for (k = 0; k < letters.Length; k++)
      {
        for (i = 0; i < worthTen.Length; i++)
        {
          if (letters[k] == worthTen[i])
          {
            score = score + 10;
            Console.WriteLine("Index values letters[i]: " + letters[i] + "; worthTen[i]: " + worthTen[i] + "; letters[k]: " + letters[k] + "; worthTen[k]: " + worthTen[k]);
            Console.WriteLine(worthTen.Length + " and " + letters.Length);
          }
          else if (letters[k] != worthTen[i])
          {
            return score;
          }
          Console.WriteLine("k is currently: " + k + " i is currently: " + i);
        }
      }
    }

  }

}

// int i, j;

//          for (i = 2; i < 100; i++) {
//             for (j = 2; j <= (i / j); j++)
//             if ((i % j) == 0) break; // if factor found, not prime
//             if (j > (i / j)) Console.WriteLine("{0} is prime", i);
//          }



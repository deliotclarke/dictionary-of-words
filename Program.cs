using System;
using System.Collections.Generic;

namespace dictionary_of_words
{
  class Program
  {
    static void Main(string[] args)
    {
      /*
  Create a dictionary with key value pairs to
  represent words (key) and its definition (value)
  */

      Dictionary<string, string> wordsAndDefinitions = new Dictionary<string, string>();

      // Add several more words and their definitions
      wordsAndDefinitions.Add("Awesome", "The feeling of students when they are learning C#");

      Dictionary<string, string> wordsToAdd = new Dictionary<string, string>() {
          {"Words", "Strings of character that may or may not be real things"},
          {"Javascript", "A computer language that allows you to do almost anything"},
          {"Classes", "I don't know, we're not supposed to talk about it"}
      };

      foreach (KeyValuePair<string, string> word in wordsToAdd)
      {
        wordsAndDefinitions.Add(word.Key, word.Value);
      }

      // foreach (KeyValuePair<string, string> word in wordsAndDefinitions)
      // {
      //   Console.WriteLine(word);
      // }

      /*
          Use square brackets to get the definition of two of the
          words and then output them to the console
      */

      Console.WriteLine(wordsAndDefinitions["Awesome"]);
      Console.WriteLine(wordsAndDefinitions["Classes"]);

      /*
          Below, loop over the wordsAndDefinitions dictionary to get the following output:
              The definition of (WORD) is (DEFINITION)
              The definition of (WORD) is (DEFINITION)
              The definition of (WORD) is (DEFINITION)
      */

      Console.WriteLine("Full definitions belowwwww:");
      Console.WriteLine();

      foreach (KeyValuePair<string, string> word in wordsAndDefinitions)
      {
        Console.WriteLine($"The definition of {word.Key} is {word.Value}.");
      }
    }
  }
}

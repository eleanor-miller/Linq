﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq
{
  class Program
  {
    // static int MultiplyBy2(int value)
    // {
    //   return value * 2;
    // }
    static void Main(string[] args)
    {
      var scores = new List<int> { 42, 100, 98, 15 };

      // Multiply by two
      Func<int, int> MultiplyBy2 = value => value * 2;

      // in this instance 'var' is an IEnumerable int
      var newScores = scores.Select(MultiplyBy2);
      foreach (var score in newScores)
      {
        Console.WriteLine(score);
      }

      Console.WriteLine(scores.Count());
      // IEnumberable count becomes a Method and no longer a property.
      Console.WriteLine(newScores.Count());
      // Make a new list to store the results
      // var newScores = new List<int>();

      // // Go through each score in the scores list
      // foreach (var score in scores)
      // {
      //   // Use the 'MultiplyBy2' expression to take score and double it
      //   var doubled = MultiplyBy2(score);

      //   // Add it to the new list
      //   newScores.Add(doubled);
      // }
      Console.WriteLine();
    }
  }
}

using System;
using System.Linq;
public class DeckOfCards
{
  public static string[] BuildDeck() => new string[] { "ace", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "jack", "queen", "king" }
  .Select(x => new string[] { " of hearts", " of spades", " of diamonds", " of clubs" }.Select(c => x + c)).SelectMany(x => x).ToArray();
}

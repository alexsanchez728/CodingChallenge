using System;
using System.Collections.Generic;
using System.Linq;

namespace CodingChallenge.PirateSpeak
{
    public class Solution
    {
        public string[] GetPossibleWords(string jumble, string[] dictionary)
        {
            var result = new List<string>();
            //var jumbleChars = jumble.ToCharArray();
            var jumbleSorted = jumble.ToCharArray().OrderBy(x => x).ToString();

            foreach (var word in dictionary)
            {
                if (word.Length == jumble.Length)
                {
                    var wordSorted = word.ToCharArray().OrderBy(x => x).ToString();

                    if (string.Equals(wordSorted, jumbleSorted, StringComparison.OrdinalIgnoreCase))
                        result.Add(word);
                    //    var wordChars = word.ToCharArray().ToList();
                    //    var numberOfMatches = 0;

                    //    foreach (var character in jumbleChars)
                    //    {
                    //        if (wordChars.Contains(character))
                    //        {
                    //            wordChars.Remove(character);
                    //            numberOfMatches++;
                    //        }
                    //    }

                    //    if (numberOfMatches == jumble.Length)
                    //        result.Add(word);
                }
            }
            return result.ToArray();



            //// break the jumble string into a object of all chars
            //var letters = jumble.ToCharArray();

            //// init a list to put the results into
            //List<string> mightHaveMeant = new List<string>();


            //foreach (var word in dictionary)
            //{

            //    // have to get the count of all the letters in each of the words..
            //    //because the letter counts need to match up

            //    foreach (var letter in letters)
            //    {

            //        if (word.Contains(letter) && !mightHaveMeant.Contains(word) && word.Length == jumble.Length)
            //        {
            //            mightHaveMeant.Add(word);
            //        }
            //    }
            //}
            //// add that matching word to the dictionary that's going to output
            //// output the resulting string list

            //return mightHaveMeant.ToArray();
        }
    }
}
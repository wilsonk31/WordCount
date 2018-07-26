using System;
using System.Linq;

namespace WordCount
{
    public static class WordCount
    {
        
        public static int GetWordCount(string searchWord, string inputString) 
        {
            // Null check these variables and determine if they have values.
            if (string.IsNullOrEmpty(searchWord) || string.IsNullOrEmpty(inputString))
            {
                return 0;
            }

            //Convert the string into an array of words
            var delimiter = new char[] { '.', '?', '!', ' ', ';', ':', ',' };
            var source = inputString.Split(delimiter, StringSplitOptions.RemoveEmptyEntries);

            // matching the words  
            var matchQuery = from word in source
                             where word.ToLowerInvariant() == searchWord.ToLowerInvariant()
                             select word;

            // Count the matches, returns the count.
            return matchQuery.Count();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GuessTheWord
{
    public class DictionaryWords
    {
        IDictionary<string, string> wordsWithHints = new Dictionary<string, string>()
        {
            { "apple", "fruit" },
            { "banana", "fruit" },
            { "tiger", "animal" },
            { "elephant", "animal" },
            { "guitar", "instrument" },
            { "violin", "instrument" },
            { "canada", "country" },
            { "brazil", "country" },
            { "laptop", "object" },
            { "microscope", "scientific instrument" }
        };
        

        Random rand = new Random();
        List<string> words = new List<string>(wordsWithHints.Keys);
        string chosenWord = words[rand.Next(words.Count)];
        string hint = wordsWithHints[chosenWord];

    }
}
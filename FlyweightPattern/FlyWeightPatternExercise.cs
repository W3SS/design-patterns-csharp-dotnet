using System.Collections.Generic;

namespace FlyweightPattern
{
    // You are given a class called Sentence , which takes a string such as "hello world". 
    // You need to provide an interface such that the indexer returns a WordToken  
    // which can be used to capitalize a particular word in the sentence.

    // Typical use would be something like:

    // var sentence = new Sentence("hello world");
    // sentence[1].Capitalize = true;
    // WriteLine(sentence); // writes "hello WORLD"

    public class Sentence
    {
        private string[] words;

        private Dictionary<int, WordToken> tokens = new Dictionary<int, WordToken>();

        public Sentence(string plainText)
        {
            words = plainText.Split(' ');
        }

        public WordToken this[int index]
        {
            get
            {
                WordToken wt = new WordToken();

                tokens.Add(index, wt);

                return tokens[index];
            }
        }

        public override string ToString()
        {
            var ws = new List<string>();

            for (var i = 0; i < words.Length; i++)
            {
                var w = words[i];

                if (tokens.ContainsKey(i) && tokens[i].Capitalize)
                {
                    w = w.ToUpperInvariant();
                }
                    
                ws.Add(w);
            }

            return string.Join(" ", ws);
        }

        public class WordToken
        {
            public bool Capitalize;
        }
    }

    class FlyWeightPatternExercise
    {
    }
}

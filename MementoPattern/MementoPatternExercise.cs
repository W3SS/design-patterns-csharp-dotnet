using System.Collections.Generic;
using System.Linq;

namespace MementoPattern
{
    // A TokenMachine  is in charge of keeping tokens. Each Token  is a reference type with a single numerical value. 
    // The machine supports adding tokens and, when it does, 
    // it returns a memento representing the state of that system at that given time.

    // You are asked to fill in the gaps and implement the Memento design pattern for this scenario.
    // Pay close attention to the situation where a token is fed in as a reference and its value is subsequently changed 
    // on that reference - you still need to return the correct system snapshot!

    public class Token
    {
        public int Value = 0;

        public Token(int value)
        {
            this.Value = value;
        }
    }

    public class MementoExe
    {
        public List<Token> Tokens = new List<Token>();
    }

    public class TokenMachine
    {
        public List<Token> Tokens = new List<Token>();

        public MementoExe AddToken(int value)
        {
            return AddToken(new Token(value));
        }

        public MementoExe AddToken(Token token)
        {
            Tokens.Add(token);

            var m = new MementoExe();
            
            // a rather roundabout way of cloning
            m.Tokens = Tokens.Select(t => new Token(t.Value)).ToList();

            return m;
        }

        public void Revert(MementoExe m)
        {
            Tokens = m.Tokens.Select(mm => new Token(mm.Value)).ToList();
        }
    }

    class MementoPatternExercise
    {
    }
}

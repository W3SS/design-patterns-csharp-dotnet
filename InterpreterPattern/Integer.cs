using InterpreterPattern.Interfaces;

namespace InterpreterPattern
{
    public class Integer : IElement
    {
        public Integer(int value)
        {
            Value = value;
        }

        public int Value { get; }
    }
}

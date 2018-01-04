using NullObjectPattern.Interfaces;

namespace NullObjectPattern
{
    public sealed class NullLog : ILog
    {
        public void Info(string msg)
        {

        }

        public void Warn(string msg)
        {

        }
    }
}

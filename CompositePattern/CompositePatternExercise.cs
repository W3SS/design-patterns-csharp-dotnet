using System.Collections;
using System.Collections.Generic;

namespace CompositePattern
{
    public interface IValueContainer : IEnumerable<int>
    {

    }

    public class SingleValue : IValueContainer
    {
        public int Value;

        public IEnumerator<int> GetEnumerator()
        {
            yield return this.Value;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }

    public class ManyValues : List<int>, IValueContainer
    {

    }

    public static class ExtensionMethods
    {
        public static int Sum(this List<IValueContainer> containers)
        {
            int result = 0;

            foreach (var c in containers)
            {
                foreach (var i in c)
                {
                    result += i;
                }
            }
                
            return result;
        }
    }

    class CompositePatternExercise
    {
    }
}

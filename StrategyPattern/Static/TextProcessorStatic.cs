using StrategyPattern.Dynamic.Interfaces;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern.Static
{
    // a.k.a. policy
    public class TextProcessorStatic<LS> where LS : IListStrategy, new()
    {
        private StringBuilder sb = new StringBuilder();

        private IListStrategy listStrategy = new LS();

        public void AppendList(IEnumerable<string> items)
        {
            listStrategy.Start(sb);

            foreach (var item in items)
            {
                listStrategy.AddListItem(sb, item);
            }
                
            listStrategy.End(sb);
        }

        public override string ToString()
        {
            return sb.ToString();
        }
    }
}

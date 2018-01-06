using System.Text;

namespace StrategyPattern.Dynamic.Interfaces
{
    public interface IListStrategy
    {
        void Start(StringBuilder sb);
        void End(StringBuilder sb);
        void AddListItem(StringBuilder sb, string item);
    }
}

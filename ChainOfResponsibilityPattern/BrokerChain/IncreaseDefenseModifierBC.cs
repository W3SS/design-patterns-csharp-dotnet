namespace ChainOfResponsibilityPattern.BrokerChain
{
    public class IncreaseDefenseModifierBC : CreatureModifierBC
    {
        public IncreaseDefenseModifierBC(Game game, CreatureBC creature) : base(game, creature)
        {
        }

        protected override void Handle(object sender, Query q)
        {
            if (q.CreatureName == creature.Name &&
                q.WhatToQuery == Query.Argument.Defense)
            {
                q.Value += 2;
            }
        }
    }
}

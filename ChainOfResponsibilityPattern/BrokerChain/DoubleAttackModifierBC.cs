namespace ChainOfResponsibilityPattern.BrokerChain
{
    public class DoubleAttackModifierBC : CreatureModifierBC
    {
        public DoubleAttackModifierBC(Game game, CreatureBC creature) : base(game, creature)
        {
        }

        protected override void Handle(object sender, Query q)
        {
            if (q.CreatureName == creature.Name &&
                q.WhatToQuery == Query.Argument.Attack)
            {
                q.Value *= 2;
            }
        }
    }
}

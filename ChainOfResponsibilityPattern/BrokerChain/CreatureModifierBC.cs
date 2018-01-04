using System;

namespace ChainOfResponsibilityPattern.BrokerChain
{
    public abstract class CreatureModifierBC : IDisposable
    {
        protected Game game;
        protected CreatureBC creature;

        protected CreatureModifierBC(Game game, CreatureBC creature)
        {
            this.game = game;
            this.creature = creature;
            game.Queries += Handle;
        }

        protected abstract void Handle(object sender, Query q);

        public void Dispose()
        {
            game.Queries -= Handle;
        }
    }
}

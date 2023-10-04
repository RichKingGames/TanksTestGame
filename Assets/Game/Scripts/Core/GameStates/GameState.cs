using Zenject;

namespace Tanks.Core.GameStates
{
    public abstract class GameState 
    {
        protected GameStatesManager Manager;


        public virtual void Initialize(GameStatesManager manager)
        {
            Manager = manager;
        }
 
        public abstract void Enter(GameState from);
        public abstract void Exit(GameState to);


        public virtual void Tick()
        {
        }

        public virtual void FixedTick()
        {
        }

        public virtual void LateTick()
        {
        }
    }
}
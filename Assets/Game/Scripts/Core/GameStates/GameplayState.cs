using Zenject;

namespace Tanks.Core.GameStates
{
    public class GameplayState : GameState
    {
        

        [Inject]
        public GameplayState()
        {
            
        }


        public override void Enter(GameState from)
        {
            Subscribe();
        }

     
        public override void Exit(GameState to)
        {
            Unsubscribe();
        }


        public override void Tick()
        {
        }

        public override void FixedTick()
        {
        }
        


        #region Subscriptions

        private void Subscribe()
        {
           
        }

        private void Unsubscribe()
        {
        }

        #endregion

        #region Analytics

        #endregion
    }
}
using Tanks.Data;
using Tanks.UI;
using Zenject;

namespace Tanks.Core.GameStates
{
    public class LoadLevelState : GameState
    {
        private readonly PanelsHolder _panelsHolder;
        private readonly GameplaySettings _settings;
       


        [Inject]
        public LoadLevelState(PanelsHolder panelsHolder,GameplaySettings settings)
        {
            _panelsHolder = panelsHolder;
            //_panel = panelsHolder.GetConcretePanel<LoadGameplayPanel>();
            _settings = settings;
        }
        
        
        
        public override void Enter(GameState from)
        {
            //_panelsHolder.Switch<LoadGameplayPanel>();
        }

        public override void Exit(GameState to)
        {
        }
        
    }
}
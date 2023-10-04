using Tanks.UI;
using Zenject;

namespace Tanks.Core.GameStates
{
    public class MenuState : GameState
    {
        private readonly PanelsHolder _panelsHolder;
        private readonly MenuPanel _panel;


        [Inject]
        public MenuState(PanelsHolder panelsHolder)
        {
            _panelsHolder = panelsHolder;
            _panel = panelsHolder.GetConcretePanel<MenuPanel>();
        }

        public override void Initialize(GameStatesManager manager)
        {
            base.Initialize(manager);
            _panel.SetClickCallbacks(StartGame);
            
        }

        private void StartGame()
        {
            Manager.LoadGame();
        }


        public override void Enter(GameState from)
        {
            _panelsHolder.Switch<MenuPanel>();
        }


        public override void Exit(GameState to)
        {
            _panelsHolder.Hide<MenuPanel>();
        }
    }
}
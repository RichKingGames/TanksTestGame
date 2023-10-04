using System;
using System.Collections.Generic;
using Zenject;

namespace Tanks.Core.GameStates
{
    public class GameStatesManager : IInitializable, ITickable, IFixedTickable, ILateTickable
    {
        [Inject]
        private GameState[] _states;

        public GameState CurrentState { get; private set; }


        private readonly Dictionary<Type, GameState> _statesDictionary = new Dictionary<Type, GameState>();


        public void Initialize()
        {
            for (var i = 0; i < _states.Length; i++)
            {
                _states[i].Initialize(this);
                _statesDictionary.Add(_states[i].GetType(), _states[i]);
            }

            SwitchState<BootstrapState>();
        }

        public void Tick()
        {
            CurrentState?.Tick();
        }

        public void FixedTick()
        {
        }

        public void LateTick()
        {
        }


        #region Change States

        public void ToMenu() => SwitchState<MenuState>();
        
        public void LoadGame() => SwitchState<LoadLevelState>();
        

        public void StartGame() => SwitchState<GameplayState>();
        
        #endregion


        private void SwitchState<T>() where T : GameState
        {
            GameState previousState = CurrentState;
            GameState targetState = _statesDictionary[typeof(T)];

            CurrentState?.Exit(targetState);
            CurrentState = targetState;
            CurrentState.Enter(previousState);
        }

        
    }
}
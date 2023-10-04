using UnityEngine;

namespace Tanks.Core.GameStates
{
    public class BootstrapState : GameState
    {
        public override void Initialize(GameStatesManager manager)
        {
            base.Initialize(manager);

            Application.targetFrameRate = 60;
        }

        public override void Enter(GameState from)
        {
            Manager.ToMenu();
        }

        public override void Exit(GameState to)
        {
        }
    }
}
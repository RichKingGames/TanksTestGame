using Tanks.Core.GameStates;
using UnityEngine;
using Zenject;


namespace Tanks.Zenject
{
    public class GameInstaller : MonoInstaller
    {
        

        public override void InstallBindings()
        {
            CreateGameStatesManager();
        }


        private void CreateGameStatesManager()
        {
            Container.BindInterfacesAndSelfTo<BootstrapState>().AsSingle();
            Container.BindInterfacesAndSelfTo<MenuState>().AsSingle();
            Container.BindInterfacesAndSelfTo<LoadLevelState>().AsSingle();
            Container.BindInterfacesAndSelfTo<GameplayState>().AsSingle();

            Container.Bind<GameState[]>().FromMethod(context =>
            {
                return new GameState[]
                {
                    context.Container.Resolve<BootstrapState>(),
                    context.Container.Resolve<MenuState>(),
                    context.Container.Resolve<LoadLevelState>(),
                    context.Container.Resolve<GameplayState>(),
                };
            });

            Container.BindInterfacesAndSelfTo<GameStatesManager>().AsSingle();
        }
    }
}
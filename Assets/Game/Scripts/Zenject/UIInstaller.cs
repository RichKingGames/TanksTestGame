using Tanks.UI;
using UnityEngine;
using Zenject;

namespace Tanks.Zenject
{
    public class UIInstaller : MonoInstaller
    {
        
        [Header("Panels:")]
        [SerializeField]
        private MenuPanel menuPanel;

        [SerializeField]
        private GameplayPanel gameplayPanel;
        
        
        public override void InstallBindings()
        {
            BindPanels();
        }

        private void BindPanels()
        {
            Container.BindInterfacesAndSelfTo<MenuPanel>().FromInstance(menuPanel).AsSingle();
            Container.BindInterfacesAndSelfTo<GameplayPanel>().FromInstance(gameplayPanel).AsSingle();
            Container.Bind<Panel[]>().FromMethod(context =>
            {
                return new Panel[]
                {
                    context.Container.Resolve<MenuPanel>(),
                    context.Container.Resolve<GameplayPanel>(),
                };
            });

            Container.BindInterfacesAndSelfTo<PanelsHolder>().AsSingle();
        }
    }
}
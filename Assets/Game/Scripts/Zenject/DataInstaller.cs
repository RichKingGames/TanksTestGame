using Tanks.Data;
using UnityEngine;
using Zenject;

namespace Tanks.Zenject
{
    public class DataInstaller : MonoInstaller
    {
        [SerializeField]
        private GameplaySettings gameplaySettings;

        
        
        public override void InstallBindings()
        {
            Container.BindInstance(gameplaySettings).AsSingle().NonLazy();
        }
    }
}
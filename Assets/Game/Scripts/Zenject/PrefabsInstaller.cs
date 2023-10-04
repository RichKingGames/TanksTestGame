using Tanks.Data;
using UnityEngine;
using Zenject;

namespace Tanks.Zenject
{
    public class PrefabsInstaller : MonoInstaller
    {
        [SerializeField]
        private GameplayPrefabs _gameplayPrefabs;
        
        [SerializeField]
        private UiPrefabs _uiPrefabs;
        
        public override void InstallBindings()
        {
            Container.BindInstance(_uiPrefabs).AsSingle();
            
            Container.BindInterfacesAndSelfTo<GameplayPrefabs>().FromInstance(_gameplayPrefabs).AsSingle();
            
        }
    }
}
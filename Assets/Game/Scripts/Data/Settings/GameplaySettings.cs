using System;
using UnityEngine;


namespace Tanks.Data
{
    [CreateAssetMenu(menuName = "Settings/Gameplay", fileName = "GameplaySettings")]
    public class GameplaySettings : ScriptableObject
    {
        public GeneralGameplaySettings General;

        public CardsSettings CardsSettings;

    }

    [Serializable]
    public class GeneralGameplaySettings
    {
      
    }

    [Serializable]
    public class CardsSettings
    {
       
    }
}
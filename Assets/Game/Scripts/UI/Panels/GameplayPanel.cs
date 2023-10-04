using System;

namespace Tanks.UI
{
    public class GameplayPanel : Panel
    {

        public override void Initialize()
        {
        }

        public override void Hide()
        {
            gameObject.SetActive(false);
        }

        public override void Show()
        {
            gameObject.SetActive(true);
        }
        
    }
}
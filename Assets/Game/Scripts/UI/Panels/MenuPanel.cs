using System;
using System.Collections.Generic;
using UnityEngine;

namespace Tanks.UI
{
    public class MenuPanel : Panel
    {

        private Action _clickCallback;


        public void SetClickCallbacks(Action startPlay)
        {
            _clickCallback = startPlay;
        }


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
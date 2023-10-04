using System;
using System.Collections.Generic;
using Zenject;

namespace Tanks.UI
{
    public class PanelsHolder
    {
        private Dictionary<Type, Panel> _panels;


        [Inject]
        public PanelsHolder(Panel[] panels)
        {
            _panels = new Dictionary<Type, Panel>();

            for (var i = 0; i < panels.Length; i++)
            {
                _panels.Add(panels[i].GetType(), panels[i]);
                
                panels[i].Initialize();
                panels[i].Hide();
            }
        }


        public T GetConcretePanel<T>() where T : Panel => _panels[typeof(T)] as T;

        //todo override for multiple
        public void Switch<T>() where T : Panel
        {
            HideAll();
            Show<T>();
        }

        public void Show<T>() where T : Panel => _panels[typeof(T)].Show();
        public void Hide<T>() where T : Panel => _panels[typeof(T)].Hide();


        private void HideAll()
        {
            foreach (var panelsPair in _panels)
                panelsPair.Value.Hide();
        }
    }
}
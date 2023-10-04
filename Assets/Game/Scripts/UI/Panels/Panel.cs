using UnityEngine;

namespace Tanks.UI
{
    public abstract class Panel : MonoBehaviour
    {
        public abstract void Initialize();
        public abstract void Hide();
        public abstract void Show();
    }
}
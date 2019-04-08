using UnityEngine.EventSystems;

namespace UnityAtoms
{
    public sealed class OnPointerDownHook : VoidHook, IPointerDownHandler
    {
        public void OnPointerDown(PointerEventData eventData)
        {
            OnHook(new Void());
        }
    }
}

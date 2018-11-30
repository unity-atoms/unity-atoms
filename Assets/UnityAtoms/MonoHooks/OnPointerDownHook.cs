using UnityEngine;
using UnityEngine.EventSystems;

namespace UnityAtoms
{
    public class OnPointerDownHook : VoidHook, IPointerDownHandler
    {
        public void OnPointerDown(PointerEventData eventData)
        {
            OnHook(new Void());
        }
    }
}
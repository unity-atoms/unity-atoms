using UnityEngine;

namespace UnityAtoms.Mobile
{
    /* Updates the TouchUserInputVariable on every Update tick. Meant to be placed on a OnUpdateMonoHook.
    */
    [CreateAssetMenu(menuName = "Unity Atoms/Mobile/Touch User Input/Update (OnUpdateMonoHook)", fileName = "UpdateTouchUserInputVariable")]
    public class UpdateTouchUserInput : VoidAction
    {
        public TouchUserInputVariable TouchUserInputVariable;

        private TouchUserInput.State inputState = TouchUserInput.State.None;
        private Vector2 inputPos = Vector2.zero;
        private Vector2 inputPosLastFrame = Vector2.zero;
        private Vector2 inputPosLastDown = Vector2.zero;

        public override void Do()
        {
#if (UNITY_ANDROID || UNITY_IOS || UNITY_IPHONE) && !UNITY_EDITOR
            if (Input.touchCount > 0)
            {
                inputPos = Input.GetTouch(0).position;
                if (Input.GetTouch(0).phase == TouchPhase.Began) 
                {
                    inputPosLastDown = inputPos;
                    inputState = TouchUserInput.State.Down;
                } 
                else if (Input.GetTouch(0).phase == TouchPhase.Ended) 
                {
                    inputState = TouchUserInput.State.Up;
                }
                else
                {
                    inputState = TouchUserInput.State.Drag;
                }
            }
            else 
            {
                inputPos = Vector2.zero;
                inputState = TouchUserInput.State.None;
            }
#elif UNITY_EDITOR || UNITY_STANDALONE
            inputPos = Input.mousePosition;

            if (Input.GetMouseButtonDown(0))
            {
                inputPosLastDown = inputPos;
                inputState = TouchUserInput.State.Down;
            }
            else if (Input.GetMouseButtonUp(0))
            {
                inputState = TouchUserInput.State.Up;
            }
            else if (Input.GetMouseButton(0))
            {
                inputState = TouchUserInput.State.Drag;
            }
            else
            {
                inputState = TouchUserInput.State.None;
            }
#endif

            TouchUserInputVariable.SetValue(new TouchUserInput(inputState, inputPos, inputPosLastFrame, inputPosLastDown));
            inputPosLastFrame = inputPos;
        }
    }
}

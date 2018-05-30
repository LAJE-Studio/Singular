using Singular.Input;
using UnityEngine;

namespace Singular {
    public class NativePlayerController : MonoBehaviour, IController {
        public bool GetButton(InputAction action) {
            return UnityEngine.Input.GetButton(action.Name);
        }

        public bool GetButtonDown(InputAction action) {
            return UnityEngine.Input.GetButtonDown(action.Name);
        }

        public bool GetButtonUp(InputAction action) {
            return UnityEngine.Input.GetButtonUp(action.Name);
        }

        public float GetAxis(InputAction action) {
            return UnityEngine.Input.GetAxis(action.Name);
        }

        public float GetAxisRaw(InputAction action) {
            return UnityEngine.Input.GetAxisRaw(action.Name);
        }
    }
}
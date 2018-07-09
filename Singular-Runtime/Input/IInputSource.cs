using UnityEngine;

namespace Singular.Input {
    public interface IInputSource {
        bool GetButton(InputAction action);
        bool GetButtonDown(InputAction action);
        bool GetButtonUp(InputAction action);
        float GetAxis(InputAction action);
        float GetAxisRaw(InputAction action);
    }

    public static class InputSourceExtensions {
        public static bool GetButtonOrDefault(this IInputSource source, InputAction action, bool defaultValue = false) {
            return CheckSourceValid(source) ? source.GetButton(action) : defaultValue;
        }

        public static bool GetButtonDownOrDefault(this IInputSource source, InputAction action,
            bool defaultValue = false) {
            return CheckSourceValid(source) ? source.GetButtonDown(action) : defaultValue;
        }

        public static bool GetButtonUpOrDefault(this IInputSource source, InputAction action,
            bool defaultValue = false) {
            return CheckSourceValid(source) ? source.GetButtonUp(action) : defaultValue;
        }

        public static float GetAxisOrDefault(this IInputSource source, InputAction action,
            float defaultValue = 1) {
            return CheckSourceValid(source) ? source.GetAxis(action) : defaultValue;
        }

        public static float GetAxisRawOrDefault(this IInputSource source, InputAction action,
            float defaultValue = 1) {
            return CheckSourceValid(source) ? source.GetAxisRaw(action) : defaultValue;
        }

        private static bool CheckSourceValid(IInputSource source) {
            return (source as Object) != null;
        }
    }
}
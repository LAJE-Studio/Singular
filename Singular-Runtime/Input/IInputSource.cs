namespace Singular.Input {
    public interface IInputSource {
        bool GetButton(InputAction action);
        bool GetButtonDown(InputAction action);
        bool GetButtonUp(InputAction action);
        float GetAxis(InputAction action);
        float GetAxisRaw(InputAction action);
    }
}
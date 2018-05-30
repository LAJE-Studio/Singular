using UnityEngine;

namespace Singular.Movement.Motors {
    public abstract class Motor : ScriptableObject {
        public abstract void Move(IMovable movable);
    }
}
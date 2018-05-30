using System;
using UnityEngine;

namespace Singular.Input {
    [Serializable]
    public sealed class InputAction {
        [SerializeField]
        private int id;

        [SerializeField]
        private string name;

        public InputAction(int id, string name) {
            this.id = id;
            this.name = name;
        }

        public int ID {
            get {
                return id;
            }
        }

        public string Name {
            get {
                return name;
            }
        }
    }
}
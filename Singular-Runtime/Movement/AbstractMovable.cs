﻿using Singular.Movement.Motors;
using UnityEngine;

namespace Singular.Movement {
    public abstract class AbstractMovable : AbstractOwnable, IMovable {
        [SerializeField]
        private Motor motor;

        public Motor Motor {
            get {
                return motor;
            }
            set {
                motor = value;
            }
        }
    }
}
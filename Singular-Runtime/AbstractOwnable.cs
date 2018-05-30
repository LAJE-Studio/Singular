using UnityEngine;

namespace Singular {
    public class AbstractOwnable : MonoBehaviour, IOwnable {
        private OwnershipRemovalCallback callback;

        public IOwner Owner {
            get;
            private set;
        }

        public void RequestOwnership(IOwner owner, OwnershipRemovalCallback removalCallback) {
            RevokeOwnership();
            callback = removalCallback;
        }

        public IOwner RevokeOwnership() {
            var oldOwner = Owner;
            if (callback != null) {
                callback();
                callback = null;
            }

            Owner = null;
            return oldOwner;
        }
    }
}
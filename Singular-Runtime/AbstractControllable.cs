using UnityEngine;

namespace Singular {
    public class AbstractControllable : MonoBehaviour, IControllable {
        private OwnershipRemovalCallback callback;

        public IController Controller {
            get;
            private set;
        }

        public void RequestOwnership(IController controller, OwnershipRemovalCallback removalCallback) {
            RevokeOwnership(OwnershipRemovalReason.Override);
            Controller = controller;
            callback = removalCallback;
        }

        public IController RevokeOwnership() {
            var oldOwner = Controller;
            RevokeOwnership(OwnershipRemovalReason.Revoked);
            return oldOwner;
        }

        private void OnDestroy() {
            RevokeOwnership(OwnershipRemovalReason.Destroyed);
        }

        private void RevokeOwnership(OwnershipRemovalReason reason) {
            var cb = callback;
            if (cb != null) {
                cb(reason);
            }
            callback = null;
            Controller = null;
        }
    }
}
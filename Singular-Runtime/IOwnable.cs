namespace Singular {
    public delegate void OwnershipRemovalCallback();

    public interface IOwnable {
        void RequestOwnership(IOwner owner, OwnershipRemovalCallback removalCallback);

        IOwner RevokeOwnership();

        IOwner Owner {
            get;
        }
    }
}
using Singular.Movement.Motors;

namespace Singular.Movement {
    public interface IMovable : IOwnable {
        Motor Motor {
            get;
            set;
        }
    }
}
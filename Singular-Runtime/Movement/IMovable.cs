using Singular.Movement.Motors;

namespace Singular.Movement {
    public interface IMovable : IControllable {
        Motor Motor {
            get;
            set;
        }
    }
}
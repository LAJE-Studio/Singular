using Singular.Input;

namespace Singular {
    /// <summary>
    /// Um "Controller" representa um objeto capaz de controlar outro (<see cref="IControllable"/>).
    /// <br/>
    /// Ele é comparável ao <a href="https://docs.unrealengine.com/en-us/Gameplay/Framework/Controller">Controller</a>
    /// da Unreal Engine.
    /// <br/>
    /// Um Controller pode ser um Player ou uma I.A., e <i>geralmente</i> existe uma relação de um para um entre um
    /// <see cref="IController"/> e um <see cref="IControllable"/>, ou seja, para cada Controller existe um Controllable. 
    /// <seealso cref="IControllable"/>
    /// </summary>
    public interface IController : IInputSource { }
}
namespace Singular {
    public delegate void OwnershipRemovalCallback(OwnershipRemovalReason reason);

    /// <summary>
    /// Representa um motivo do porque o controle de um <see cref="IController"/> foi revogado de um
    /// <see cref="IControllable"/>.
    /// </summary>
    public enum OwnershipRemovalReason {
        /// <summary>
        /// Usndo quando o método <see cref="IControllable.RevokeOwnership"/> for chamado.
        /// </summary>
        Revoked,

        /// <summary>
        /// Usado quando o método <see cref="IControllable.RequestOwnership"/> for chamado e o se controllable
        /// já tivesse um <see cref="IController"/> do qual ele estava recebendo comandos. 
        /// </summary>
        Override,

        /// <summary>
        /// Usado quando o <see cref="IControllable"/> for destruido e ele estava sendo controlado por algum controller.
        /// </summary>
        Destroyed
    }

    /// <summary>
    /// Representa um objeto que recebe ordens de um <see cref="IController"/> e reage a elas de alguma maneira.
    /// <br/>
    /// Comparável ao <a href="https://docs.unrealengine.com/en-us/Gameplay/Framework/Pawn">Pawn</a> da Unreal Engine
    /// </summary>
    public interface IControllable {
        /// <summary>
        /// Faz este controllable começar a ser comandado pelo <paramref name="controller"/> fornecido.
        /// <br/>
        /// Caso este controllable já estivesse sendo controlado por outro <see cref="IController"/>, ele notificará o
        /// antigo controller que seu controle foi revogado usando o <paramref name="removalCallback"/> que foi
        /// fornecido por ele passando como motivo <see cref="OwnershipRemovalReason.Override"/>.
        /// </summary>
        /// <param name="controller">O Controller a partir do qual este Controllable começará a receber inputs</param>
        /// <param name="removalCallback">O callback que será chamado quando, por qualquer motivo, este Controllable
        /// parar de ser comandado pelo <paramref name="controller"/> fornecido.
        /// </param>
        void RequestOwnership(IController controller, OwnershipRemovalCallback removalCallback);

        /// <summary>
        /// 
        /// </summary>
        /// <returns>O antigo controller que comandava este controllable, ou <i>null</i> caso não exista algum.</returns>
        IController RevokeOwnership();

        /// <summary>
        /// O Controller do qual este controllable está atualmente recebendo comandos.
        /// </summary>
        IController Controller {
            get;
        }
    }
}
using Microsoft.Practices.Unity;

namespace Framework.AssetLibrary.DI
{
    /// <summary>
    ///     Interface IDIContainer
    /// </summary>
    public interface IDIContainer
    {
        /// <summary>
        ///     Gets the container.
        /// </summary>
        /// <value>The container.</value>
        IUnityContainer Container { get; }
    }
}
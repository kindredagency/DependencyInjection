using Microsoft.Practices.Unity;

namespace Framework.AssetLibrary.DI
{
    /// <summary>
    ///     Class DIContainer.
    /// </summary>
    public class DIContainer : IDIContainer
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="DIContainer" /> class.
        /// </summary>
        public DIContainer()
        {
            Container = new UnityContainer();
        }

        /// <summary>
        ///     Gets the container.
        /// </summary>
        /// <value>The container.</value>
        public IUnityContainer Container { get; }
    }
}
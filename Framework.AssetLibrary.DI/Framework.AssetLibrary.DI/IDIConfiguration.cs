using Microsoft.Practices.Unity;

namespace Framework.AssetLibrary.DI
{
    /// <summary>
    ///     Interface IDIConfiguration
    /// </summary>
    public interface IDIConfiguration
    {
        /// <summary>
        ///     Configurations the specified container.
        /// </summary>
        /// <param name="container">The container.</param>
        void Configuration(IUnityContainer container);
    }
}
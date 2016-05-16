using Framework.AssetLibrary.Caching;
using Microsoft.Practices.Unity;

namespace Framework.AssetLibrary.DI
{
    public class DIFactory : IDIFactory
    {
        #region Constructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="DIFactory" /> class.
        /// </summary>
        public DIFactory()
        {
            var cacheContext = CacheFactory.GetContext();

            if (!cacheContext.Contains(UnityContainerCacheKey))
            {
                _unityContainer = new UnityContainer();
                cacheContext.Add(UnityContainerCacheKey, _unityContainer);
            }
            else
            {
                _unityContainer = cacheContext.Get<IUnityContainer>(UnityContainerCacheKey) ;
            }
        }

        #endregion Constructors

        #region Private variables

        private const string UnityContainerCacheKey = "Framework.AssetLibrary.DI.Unity.Container";
        private readonly IUnityContainer _unityContainer;

        #endregion Private variables

        #region IUnityFactory Implementations

        /// <summary>
        ///     Gets the container.
        /// </summary>
        /// <returns>IUnityContainer.</returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public IUnityContainer GetContext()
        {
            return _unityContainer;
        }

        /// <summary>
        /// Registers the specified settings.
        /// </summary>
        /// <param name="settings">The settings.</param>
        public void Register(IDIConfiguration settings)
        {
            settings.Configuration(_unityContainer);
        }

        #endregion IUnityFactory Implementations
    }
}
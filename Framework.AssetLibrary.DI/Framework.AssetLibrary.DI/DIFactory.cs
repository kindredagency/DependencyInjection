using Framework.AssetLibrary.Caching;

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
                _Container = new DIContainer();
                cacheContext.Add(UnityContainerCacheKey, _Container);
            }
            else
            {
                _Container = cacheContext.Get<IDIContainer>(UnityContainerCacheKey);
            }
        }

        #endregion Constructors

        #region Private variables

        private const string UnityContainerCacheKey = "Framework.AssetLibrary.DI.Unity.Container";
        private readonly IDIContainer _Container;

        #endregion Private variables

        #region IUnityFactory Implementations

        /// <summary>
        ///     Gets the context.
        /// </summary>
        /// <returns>IDIContainer.</returns>
        public IDIContainer GetContext()
        {
            return _Container;
        }

        /// <summary>
        ///     Registers the specified settings.
        /// </summary>
        /// <param name="settings">The settings.</param>
        public void Register(IDIConfiguration settings)
        {
            settings.Configuration(_Container.Container);
        }

        #endregion IUnityFactory Implementations
    }
}
using Microsoft.Practices.Unity;

namespace Framework.AssetLibrary.DI
{
    public interface IDIConfiguration
    {
        void Configuration(IUnityContainer container);
    }
}
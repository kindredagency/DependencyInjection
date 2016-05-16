using Microsoft.Practices.Unity;

namespace Framework.AssetLibrary.DI
{
    public interface IDIFactory
    {
        IUnityContainer GetContext();
        void Register(IDIConfiguration value);
    }
}
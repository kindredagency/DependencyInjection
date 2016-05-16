using Microsoft.Practices.Unity;

namespace Framework.AssetLibrary.DI
{
    public interface IDIFactory
    {
        IDIContainer GetContext();
        void Register(IDIConfiguration value);
    }
}
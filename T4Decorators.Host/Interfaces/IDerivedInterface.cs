using T4Decorators.Host.Generated.Interfaces;

namespace T4Decorators.Host.Interfaces
{
    public partial interface IDerivedInterface : ISimpleTest
    {
        ISimpleTest GetTestDefault(IDerivedInterface derivedInterface, bool defaultBool = true);
    }
}
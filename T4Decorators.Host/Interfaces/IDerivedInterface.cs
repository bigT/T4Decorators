using T4Decorators.Host.Generated.Interfaces;

namespace T4Decorators.Host.Interfaces
{
    public partial interface IDerivedInterface : ISimple
    {
        ISimple DefaultParamMethod(IDerivedInterface derivedInterface, bool defaultBool = true);
    }
}
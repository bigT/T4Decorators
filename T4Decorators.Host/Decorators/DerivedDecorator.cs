using T4Decorators.Host.Interfaces;

namespace T4Decorators.Host.Decorators
{
    partial class DerivedDecorator : IDerivedInterface
    {
        private readonly IDerivedInterface derivedInterface;

        public DerivedDecorator(IDerivedInterface derivedInterface)
        {
            this.derivedInterface = derivedInterface;
        }
    }
}

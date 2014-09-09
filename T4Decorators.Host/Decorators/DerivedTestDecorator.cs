using T4Decorators.Host.Interfaces;

namespace T4Decorators.Host.Decorators
{
    partial class DerivedTestDecorator : IDerivedInterface
    {
        private readonly IDerivedInterface derivedInterface;

        public DerivedTestDecorator(IDerivedInterface derivedInterface)
        {
            this.derivedInterface = derivedInterface;
        }
    }
}

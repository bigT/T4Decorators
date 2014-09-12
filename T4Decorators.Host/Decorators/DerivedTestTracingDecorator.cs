using System;
using T4Decorators.Host.Interfaces;

namespace T4Decorators.Host.Decorators
{
    partial class DerivedTestTracingDecorator : IDerivedInterface
    {
        private readonly IDerivedInterface derivedInterface;

        public DerivedTestTracingDecorator(IDerivedInterface derivedInterface)
        {
            this.derivedInterface = derivedInterface;
        }

        public IDisposable CreateTracingContext(string name)
        {
            throw new NotImplementedException();
        }
    }
}

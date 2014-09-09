using T4Decorators.Host.Generated.Interfaces;

namespace T4Decorators.Host.Decorators
{
    partial class SimpleConstructorOnlyTestDecorator : ISimpleTest
    {
        private readonly ISimpleTest simpleTest;

        public SimpleConstructorOnlyTestDecorator(ISimpleTest simpleTest)
        {
            this.simpleTest = simpleTest;
        }
    }
}

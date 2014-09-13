using T4Decorators.Host.Generated.Interfaces;

namespace T4Decorators.Host.Decorators
{
    partial class SimpleDecorator : ISimple
    {
        private readonly ISimple simple;

        public SimpleDecorator(ISimple simple)
        {
            this.simple = simple;
        }
    }
}

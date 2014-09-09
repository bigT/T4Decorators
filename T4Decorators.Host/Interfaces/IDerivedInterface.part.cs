namespace T4Decorators.Host.Interfaces
{
    public partial interface IDerivedInterface
    {
        IDerivedInterface MethodWithParamsTest(params string[] testParams);
    }
}
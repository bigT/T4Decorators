namespace T4Decorators.Host.Interfaces
{
    public partial interface IDerivedInterface
    {
        IDerivedInterface ParamsParamMethod(params string[] testParams);
    }
}
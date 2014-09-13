namespace T4Decorators.Host.Generated.Interfaces
{
    public interface ISimple
    {
        string Read { get; }

        string Write { set; }

        string ReadWrite { get; set; }

        void VoidMethod();

        ISimple GetMethodTest();

        void OneParamMethod(ISimple simple);

        ISimple OutParamMethod(out ISimple simple);

        ISimple RefParamMethod(ref ISimple simple);
    }
}
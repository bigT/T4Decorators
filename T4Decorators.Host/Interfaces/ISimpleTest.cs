namespace T4Decorators.Host.Generated.Interfaces
{
    public interface ISimpleTest
    {
        string GetterTest { get; }

        string SetterTest { set; }

        string GetterAndSetterTest { get; set; }

        void VoidMethodTest();

        ISimpleTest GetMethodTest();

        void SetTestMethod(ISimpleTest simpleTest);

        ISimpleTest OutMethodTest(out ISimpleTest simpleTest);

        ISimpleTest RefMethodTest(ref ISimpleTest simpleTest);
    }
}
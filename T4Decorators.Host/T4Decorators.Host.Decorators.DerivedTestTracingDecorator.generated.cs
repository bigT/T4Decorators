// <auto-generated />
#pragma warning disable 1591
#region T4Decorator

using System;
using System.Diagnostics;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace T4Decorators.Host.Decorators
{
    [GeneratedCode("T4Decorator", "1.0"), DebuggerNonUserCode]
    internal partial class DerivedTestTracingDecorator : T4Decorators.Host.Generated.ITracingContextFactory
    {

        public string GetterTest
        {
            get
            {
                using (this.CreateTracingContext("DerivedTestTracingDecorator.GetterTest(Getter)"))
                {
                    return this.derivedInterface.GetterTest;
                }
            }
        }

        public string SetterTest
        {
            set
            {
                using (this.CreateTracingContext("DerivedTestTracingDecorator.SetterTest(Setter)"))
                {
                    this.derivedInterface.SetterTest = value;
                }
            }
        }

        public string GetterAndSetterTest
        {
            get
            {
                using (this.CreateTracingContext("DerivedTestTracingDecorator.GetterAndSetterTest(Getter)"))
                {
                    return this.derivedInterface.GetterAndSetterTest;
                }
            }
            set
            {
                using (this.CreateTracingContext("DerivedTestTracingDecorator.GetterAndSetterTest(Setter)"))
                {
                    this.derivedInterface.GetterAndSetterTest = value;
                }
            }
        }

        public void VoidMethodTest()
        {
            using (this.CreateTracingContext("DerivedTestTracingDecorator.VoidMethodTest()"))
            {
                this.derivedInterface.VoidMethodTest();
            }
        }

        public T4Decorators.Host.Generated.Interfaces.ISimpleTest GetMethodTest()
        {
            using (this.CreateTracingContext("DerivedTestTracingDecorator.GetMethodTest()"))
            {
                return this.derivedInterface.GetMethodTest();
            }
        }

        public void SetTestMethod(T4Decorators.Host.Generated.Interfaces.ISimpleTest simpleTest)
        {
            using (this.CreateTracingContext("DerivedTestTracingDecorator.SetTestMethod(simpleTest)"))
            {
                this.derivedInterface.SetTestMethod(simpleTest);
            }
        }

        public T4Decorators.Host.Generated.Interfaces.ISimpleTest OutMethodTest(out T4Decorators.Host.Generated.Interfaces.ISimpleTest simpleTest)
        {
            using (this.CreateTracingContext("DerivedTestTracingDecorator.OutMethodTest(out simpleTest)"))
            {
                return this.derivedInterface.OutMethodTest(out simpleTest);
            }
        }

        public T4Decorators.Host.Generated.Interfaces.ISimpleTest RefMethodTest(ref T4Decorators.Host.Generated.Interfaces.ISimpleTest simpleTest)
        {
            using (this.CreateTracingContext("DerivedTestTracingDecorator.RefMethodTest(ref simpleTest)"))
            {
                return this.derivedInterface.RefMethodTest(ref simpleTest);
            }
        }

        public T4Decorators.Host.Generated.Interfaces.ISimpleTest GetTestDefault(T4Decorators.Host.Interfaces.IDerivedInterface derivedInterface, bool defaultBool)
        {
            using (this.CreateTracingContext("DerivedTestTracingDecorator.GetTestDefault(derivedInterface, defaultBool)"))
            {
                return this.derivedInterface.GetTestDefault(derivedInterface, defaultBool);
            }
        }

        public T4Decorators.Host.Interfaces.IDerivedInterface MethodWithParamsTest(params string[] testParams)
        {
            using (this.CreateTracingContext("DerivedTestTracingDecorator.MethodWithParamsTest(testParams)"))
            {
                return this.derivedInterface.MethodWithParamsTest(testParams);
            }
        }

    }
}
#endregion T4Decorator
#pragma warning restore 1591
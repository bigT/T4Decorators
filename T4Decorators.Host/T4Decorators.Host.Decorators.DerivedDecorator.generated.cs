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
    internal partial class DerivedDecorator
    {
        public string Read
        {
            get { return this.derivedInterface.Read; }
        }

        public string Write
        {
            set { this.derivedInterface.Write = value; }
        }

        public string ReadWrite
        {
            get { return this.derivedInterface.ReadWrite; }
            set { this.derivedInterface.ReadWrite = value; }
        }

        public void VoidMethod()
        {
            this.derivedInterface.VoidMethod();
        }

        public T4Decorators.Host.Generated.Interfaces.ISimple GetMethodTest()
        {
            return this.derivedInterface.GetMethodTest();
        }

        public void OneParamMethod(T4Decorators.Host.Generated.Interfaces.ISimple simple)
        {
            this.derivedInterface.OneParamMethod(simple);
        }

        public T4Decorators.Host.Generated.Interfaces.ISimple OutParamMethod(out T4Decorators.Host.Generated.Interfaces.ISimple simple)
        {
            return this.derivedInterface.OutParamMethod(out simple);
        }

        public T4Decorators.Host.Generated.Interfaces.ISimple RefParamMethod(ref T4Decorators.Host.Generated.Interfaces.ISimple simple)
        {
            return this.derivedInterface.RefParamMethod(ref simple);
        }

        public T4Decorators.Host.Generated.Interfaces.ISimple DefaultParamMethod(T4Decorators.Host.Interfaces.IDerivedInterface derivedInterface, bool defaultBool)
        {
            return this.derivedInterface.DefaultParamMethod(derivedInterface, defaultBool);
        }

        public T4Decorators.Host.Interfaces.IDerivedInterface ParamsParamMethod(params string[] testParams)
        {
            return this.derivedInterface.ParamsParamMethod(testParams);
        }

    }
}
#endregion T4Decorator
#pragma warning restore 1591
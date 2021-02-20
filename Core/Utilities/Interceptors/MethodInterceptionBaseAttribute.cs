using Castle.DynamicProxy;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Interceptors
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true, Inherited = true)] //classs lara veya methotlada ekleyebilirsin,birden fazla ekelyebilirsin,inherited edilen bir noktada da bu attiribute da eklenebilir 
    public abstract class MethodInterceptionBaseAttribute : Attribute, IInterceptor
    {
        public int Priority { get; set; }  //öncelik

        public virtual void Intercept(IInvocation invocation)
        {

        }
    }
}

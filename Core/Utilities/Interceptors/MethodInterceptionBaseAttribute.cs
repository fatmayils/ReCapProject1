using Castle.DynamicProxy;//autofac intercaption özelliğinden geliyor
using System;

namespace Core.Utilities.Interceptors
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true, Inherited = true)]
        public abstract class MethodInterceptionBaseAttribute : Attribute, IInterceptor
        {
            public int Priority { get; set; }//öncelik

        //i.i boş sonra doldurcazl
            public virtual void Intercept(IInvocation invocation)
            {

            }
        }

}



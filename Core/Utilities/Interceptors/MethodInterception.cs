using Castle.DynamicProxy;
using System;

namespace Core.Utilities.Interceptors
{
    //teml try cath lerim bunlar
    //gidip her yerde try catch yazmıyorum,bunu kullancaz,burdaki kurallardan geççek metodlarımız
    public abstract class MethodInterception:MethodInterceptionBaseAttribute
    {
        //içleri boi,aspect de hangisini doldurursak o çalışçak
        protected virtual void OnBefore(IInvocation invocation) { }
        protected virtual void OnAfter(IInvocation invocation) { }
        protected virtual void OnException(IInvocation invocation,System.Exception e) { }
        protected virtual void OnSuccess(IInvocation invocation) { }
        public override void Intercept(IInvocation invocation)//invocation : çalıştırmak istediğin metodun
        {
            var isSuccess = true;
            OnBefore(invocation);//başında
            try
            {
                invocation.Proceed();
            }
            catch (Exception e)//hata aldığında
            {
                isSuccess = false;
                OnException(invocation,e);
                throw;
            }
            finally//metot başarılı olduğunda
            {
                if (isSuccess)
                {
                    OnSuccess(invocation);
                }
            }
            OnAfter(invocation);//metodtan sonra
        }
    }

}



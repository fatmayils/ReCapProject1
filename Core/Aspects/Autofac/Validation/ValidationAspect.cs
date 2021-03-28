using Castle.DynamicProxy;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Interceptors;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Aspects.Autofac.Validation
{
    //bu bir attribute
    public class ValidationAspect : MethodInterception
    {
        private Type _validatorType;
        //tipini yolla,tip istiyor
        public ValidationAspect(Type validatorType)
        {
            //validation değilse kız
            if (!typeof(IValidator).IsAssignableFrom(validatorType))
            {
                throw new System.Exception("bir bir doğrulama sınıfı değildir");
            }

            _validatorType = validatorType;
        }
        protected override void OnBefore(IInvocation invocation)
        {
            var validator = (IValidator)Activator.CreateInstance(_validatorType);//Reflection yapısı bu
            //Reflection çalışma anında birşeylerin çalışmasını sağlıyor
            var entityType = _validatorType.BaseType.GetGenericArguments()[0];//çalışma tipini bul
            var entities = invocation.Arguments.Where(t => t.GetType() == entityType);//invocation metod demek//generik tipini bul
            foreach (var entity in entities)
            {
                ValidationTool.Validate(validator, entity);
            }
        }
    }
}

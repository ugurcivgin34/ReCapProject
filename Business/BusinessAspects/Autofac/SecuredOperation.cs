using Business.Constans;
using Castle.DynamicProxy;
using Core.Extensions;
using Core.Utilities.Interceptors;
using Core.Utilities.IoC;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.BusinessAspects.Autofac
{
    public class SecuredOperation : MethodInterception
    {
        //JWT
        private string[] _roles;
        private IHttpContextAccessor _httpContextAccessor;  //json web token isteği yapılınca göndererek yani,oraya binlerce kişi istek yapabilir.Her istek için bir httpcontext oluşur.Thread oluşlur yani.

        public SecuredOperation(string roles)  //rolleri virgülle ayırarak getirebiliyoruz anca.Attirubte çünkü
        {
            _roles = roles.Split(',');
            _httpContextAccessor = ServiceTool.ServiceProvider.GetService<IHttpContextAccessor>();

        }

        protected override void OnBefore(IInvocation invocation)
        {
            var roleClaims = _httpContextAccessor.HttpContext.User.ClaimRoles();
            foreach (var role in _roles)
            {
                if (roleClaims.Contains(role))
                {
                    return;
                }
            }
            throw new Exception(Messages.AuthorizationDenied);
        }
    }
}

﻿using System.Data.Entity;
using BLL.Interfaces;
using BLL.Services;
using DAL.Interfaces;
using DAL.Repositories;
using Ninject;
using Ninject.Web.Common;
using ORM;

namespace DependencyResolver
{
    public static class ResloverConfig
    {
        public static void ConfigurateResolverWeb(this IKernel kernel) => Configure(kernel, true);

        public static void ConfigurateResolverConsole(this IKernel kernel) => Configure(kernel, false);

        private static void Configure(IKernel kernel, bool isWeb)
        {
            if (isWeb)
            {
                kernel.Bind<IUnitOfWork>().To<UnitOfWork>().InRequestScope();
                kernel.Bind<DbContext>().To<DbModel>().InRequestScope();
            }
            else
            {
                kernel.Bind<IUnitOfWork>().To<UnitOfWork>().InSingletonScope();
                kernel.Bind<DbContext>().To<DbModel>().InSingletonScope();
            }

            kernel.Bind<IUserService>().To<UserService>();
            kernel.Bind<IRoleService>().To<RoleService>();
            kernel.Bind<IMerchandiseService>().To<MerchandiseService>();
            kernel.Bind<IRequestService>().To<RequestService>();
            kernel.Bind<IRequestMerchandiseService>().To<RequestMerchandiseService>();

            kernel.Bind<IUserRepository>().To<UserRepository>();
            kernel.Bind<IRoleRepository>().To<RoleRepository>();
            kernel.Bind<IMerchandiseRepository>().To<MerchandiseRepository>();
            kernel.Bind<IRequestRepository>().To<RequestRepository>();
            kernel.Bind<IRequestMerchandiseRepository>().To<RequestMerchndiseRepository>();
        }
    }
}

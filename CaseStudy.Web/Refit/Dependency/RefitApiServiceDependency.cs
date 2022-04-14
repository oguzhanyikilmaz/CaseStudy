using CaseStudy.Web.Refit.Interfaces;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Refit;
using System;

namespace CaseStudy.Web.Refit.Dependency
{
    public class RefitApiServiceDependency
    {

        #region fields

        private static RefitApiServiceDependency shared;
        private static object obj = new object();

        #endregion


        internal static IServiceCollection Services { get; set; }
        internal static IServiceProvider ServiceProvider { get; private set; }
        internal static IConfiguration Configuration { get; set; }

        private static RefitApiServiceDependency Shared
        {
            get
            {
                if (shared == null)
                {
                    lock (obj)
                    {
                        if (shared == null)
                        {
                            shared = new RefitApiServiceDependency();
                        }
                    }
                }

                return shared;
            }
        }



        private IReceiptApi _ReceiptApi { get => ServiceProvider.GetRequiredService<IReceiptApi>(); }

        //Exposed public static props via RefitApiServiceDependency.Shared 
        public static IReceiptApi ReceiptApi { get => Shared._ReceiptApi; }
        




        private RefitApiServiceDependency()
        {
            if (Services == null)
                Services = new ServiceCollection();

            Init();
        }

        private void Init()
        {
            ConfigureServices(Services);
            ServiceProvider = Services.BuildServiceProvider();
        }

        private void ConfigureServices(IServiceCollection services)
        {
            //services.AddTransient<AuthTokenHandler>();
            services.AddHttpContextAccessor();
            services.AddSingleton<AppSettings>();


            // APP SETTINGS
            var configBuilder = new ConfigurationBuilder().AddJsonFile("FactorySettings.json", optional: true);
            var config = configBuilder.Build();
            services.Configure<AppSettings>(config);

            var baseaddress = new Uri("http://localhost:44319/api");

            services.AddRefitClient<IReceiptApi>()
            .ConfigureHttpClient(c =>
            {
                c.BaseAddress = baseaddress;
            });
            //.AddHttpMessageHandler<AuthTokenHandler>()
            //.AddTransientHttpErrorPolicy(p => p.RetryAsync());
            
        }

    }
}

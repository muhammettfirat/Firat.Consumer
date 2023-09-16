using Localization.Resources.AbpUi;
using Firat.Consumer.Localization;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Microsoft.Extensions.DependencyInjection;

namespace Firat.Consumer;

[DependsOn(
    typeof(ConsumerApplicationContractsModule),
    typeof(AbpAspNetCoreMvcModule))]
public class ConsumerHttpApiModule : AbpModule
{
    public override void PreConfigureServices(ServiceConfigurationContext context)
    {
        PreConfigure<IMvcBuilder>(mvcBuilder =>
        {
            mvcBuilder.AddApplicationPartIfNotExists(typeof(ConsumerHttpApiModule).Assembly);
        });
    }

    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpLocalizationOptions>(options =>
        {
            options.Resources
                .Get<ConsumerResource>()
                .AddBaseTypes(typeof(AbpUiResource));
        });
    }
}

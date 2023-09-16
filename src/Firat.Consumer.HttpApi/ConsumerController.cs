using Firat.Consumer.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Firat.Consumer;

public abstract class ConsumerController : AbpControllerBase
{
    protected ConsumerController()
    {
        LocalizationResource = typeof(ConsumerResource);
    }
}

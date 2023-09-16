using Firat.Consumer.Localization;
using Volo.Abp.Application.Services;

namespace Firat.Consumer;

public abstract class ConsumerAppService : ApplicationService
{
    protected ConsumerAppService()
    {
        LocalizationResource = typeof(ConsumerResource);
        ObjectMapperContext = typeof(ConsumerApplicationModule);
    }
}

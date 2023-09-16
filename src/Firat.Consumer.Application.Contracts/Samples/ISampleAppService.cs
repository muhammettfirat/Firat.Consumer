using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace Firat.Consumer.Samples;

public interface ISampleAppService : IApplicationService
{
    Task<SampleDto> GetAsync();

    Task<SampleDto> GetAuthorizedAsync();
}

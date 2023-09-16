using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace Firat.Consumer
{
    public interface IGetQueueAppService
    {
        Task<string> Queue();
    }
}

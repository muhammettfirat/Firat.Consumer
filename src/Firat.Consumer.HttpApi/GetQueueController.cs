using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Volo.Abp;

namespace Firat.Consumer
{
    [Area(ConsumerRemoteServiceConsts.ModuleName)]
    [RemoteService(Name = ConsumerRemoteServiceConsts.RemoteServiceName)]
    [Route("api/Consumer/addqueue")]
    public class GetQueueController: ConsumerController,IGetQueueAppService
    {
        private readonly IGetQueueAppService _getQueueAppService;
        public GetQueueController(IGetQueueAppService getQueueAppService)
        {
            _getQueueAppService = getQueueAppService;
        }
        [HttpGet]
        public async Task<string> Queue()
        {
            return await _getQueueAppService.Queue();
        }
    }
}

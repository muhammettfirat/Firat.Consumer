using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Channels;
using System.Threading.Tasks;
using Volo.Abp.Application;
using Volo.Abp.Application.Services;
using static Firat.Consumer.GetQueueAppService;

namespace Firat.Consumer
{
    public class GetQueueAppService: ApplicationService,IGetQueueAppService
    {
        private readonly IConnection _connection;
        private readonly IModel _channel;
        public GetQueueAppService()
        {
            ConnectionFactory factory = new ConnectionFactory
            {
                HostName = "localhost"
            };

            _connection = factory.CreateConnection();
            _channel = _connection.CreateModel();
            _channel.QueueDeclare("mesajkuyrugu", false, false, false);
        }
  
        public virtual async Task<string> Queue()
        {
            var messageChannel = Channel.CreateUnbounded<string>();

            EventingBasicConsumer consumer = new EventingBasicConsumer(_channel);

            consumer.Received += (model, e) =>
            {
                var receivedMessage = Encoding.UTF8.GetString(e.Body.Span);

                // Mesajı işledikten sonra, kanala yazın
                messageChannel.Writer.TryWrite(receivedMessage);

                // Mesajı işlendik olarak işaretleyin
                _channel.BasicAck(e.DeliveryTag, false);
            };

            _channel.BasicConsume("mesajkuyrugu", false, consumer);

            // Kanaldan gelen ilk mesajı bekleyin
            if (await messageChannel.Reader.WaitToReadAsync())
            {
                // İlk mesajı okuyun
                var message = await messageChannel.Reader.ReadAsync();
                return message;
            }

            return null; // Eğer mesaj gelmezse null dönebilirsiniz.
        }

    }
  
    public class ResultETO
    {
        public bool? IsSuccess { get; set; }
        public object? Data { get; set; }
        public List<string> Reason { get; set; }
        public ResultETO()
        {
            Reason = new List<string>();
        }
    }
}

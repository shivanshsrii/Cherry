using Azure.Messaging.ServiceBus;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Cherry.MessageBus
{
    //hello
    public class MessageBus : IMessageBus
    {
        private string connectionString = "Endpoint=sb://cherryweb.servicebus.windows.net/;SharedAccessKeyName=RootManageSharedAccessKey;SharedAccessKey=CN0HnFwXobc2/k+DMUzcJVFWl7fwVSuGt+ASbM3gHT8=";
        public async Task PublishMessage(object message,string topic_queue_Name)
        {
            var configuration = new ConfigurationBuilder().SetBasePath(AppContext.BaseDirectory).AddJsonFile("appSettings.json").Build();
            Console.WriteLine(connectionString); 
            await using var client = new ServiceBusClient(connectionString);
            ServiceBusSender sender=client.CreateSender(topic_queue_Name);
            var jsonMessage=JsonConvert.SerializeObject(message);
            ServiceBusMessage finalMessage = new ServiceBusMessage(Encoding.UTF8.GetBytes(jsonMessage))
            {
                CorrelationId = Guid.NewGuid().ToString(),
            };
            await sender.SendMessageAsync(finalMessage);    
            await client.DisposeAsync();
        }
    } 
}

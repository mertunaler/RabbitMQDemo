using RabbitMQ.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RabbitMQDemo
{
    public class Publisher
    {
        private readonly RabbitMQService _rabbitMqService;
        public Publisher(string queueName, string message)
        {
            _rabbitMqService = new RabbitMQService();

            using (var conn = _rabbitMqService.GetConnection())
            {
                using (var channel = conn.CreateModel())
                {
                    channel.QueueDeclare(queueName, false, false, false, null);

                    channel.BasicPublish("", queueName, null, Encoding.UTF8.GetBytes(message));

                    Console.WriteLine("{0} queue'su üzerine, \"{1}\" mesajı yazıldı.", queueName, message);
                }
            }
        }
    }
}

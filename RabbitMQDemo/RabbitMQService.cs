using RabbitMQ.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RabbitMQDemo
{
    public class RabbitMQService
    {
        private readonly string _hostName  = "localhost"; 
        
        public IConnection GetConnection()
        {
            ConnectionFactory connectionFactory = new ConnectionFactory()
            {
                HostName = _hostName,
            };

            return connectionFactory.CreateConnection();
        }
    }
}

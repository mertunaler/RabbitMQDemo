using RabbitMQDemo;

class Program
{
    private static readonly string _queueName = "DENEMEQUEUE";
    private static Publisher _publisher;
    private static Consumer _consumer;

    static void Main(string[] args)
    {
         var messageToSend = Console.ReadLine();

        _publisher = new Publisher(_queueName, messageToSend);

        _consumer = new Consumer(_queueName);
    }
}
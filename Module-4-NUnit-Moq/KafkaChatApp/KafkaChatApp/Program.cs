using Confluent.Kafka;

Console.WriteLine("Choose Mode:");
Console.WriteLine("1. Producer");
Console.WriteLine("2. Consumer");

string? choice = Console.ReadLine();

var config = new ProducerConfig
{
    BootstrapServers = "localhost:9092"
};

if (choice == "1")
{
    using var producer = new ProducerBuilder<Null, string>(config).Build();

    Console.WriteLine("Type messages (type 'exit' to quit)");

    while (true)
    {
        string? message = Console.ReadLine();

        if (message?.ToLower() == "exit")
            break;

        producer.Produce("ChatTopic", new Message<Null, string>
        {
            Value = message
        });

        producer.Flush(TimeSpan.FromSeconds(5));
    }
}
else
{
    var consumerConfig = new ConsumerConfig
    {
        BootstrapServers = "localhost:9092",
        GroupId = "chat-group",
        AutoOffsetReset = AutoOffsetReset.Earliest
    };

    using var consumer = new ConsumerBuilder<Ignore, string>(consumerConfig).Build();

    consumer.Subscribe("ChatTopic");

    Console.WriteLine("Listening...");

    while (true)
    {
        var result = consumer.Consume();

        Console.WriteLine($"Received : {result.Message.Value}");
    }
}
using KafkaFlow;
using SigtermSigkillPoc;

IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices(services =>
    {
        services.AddHostedService<Worker>();
        //services.AddKafka(b => b.AddCluster(c => c.WithBrokers("")))
    })
    .Build();

await host.RunAsync();

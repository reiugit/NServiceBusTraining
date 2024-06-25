using NServiceBusTraining.Commands;


var endpointConfiguration = new EndpointConfiguration("NServiceBusTraining");
endpointConfiguration.UseSerialization<SystemJsonSerializer>();
endpointConfiguration.UseTransport<LearningTransport>(); // use InMemory "LearningTransport"

var endpointInstance = await Endpoint.Start(endpointConfiguration);

for (int i = 1; i <= 3; i++)
{
    var command = new ExampleCommand($"Example Text {i}");
    await endpointInstance.SendLocal(command);

    await Task.Delay(1000);
}

await endpointInstance.Stop();

Console.WriteLine("\nFinished.");

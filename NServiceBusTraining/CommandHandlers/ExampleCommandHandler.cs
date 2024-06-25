using NServiceBusTraining.Commands;

namespace NServiceBusTraining.CommandHandlers;

public class ExampleCommandHandler : IHandleMessages<ExampleCommand>
{
public async Task Handle(ExampleCommand message, IMessageHandlerContext context)
{
    Console.WriteLine($"Received command with text: {message.Text}");

    var forwardCommand = new ForwardCommand(message.Text + " forwarded");
    await context.SendLocal(forwardCommand);
}
}

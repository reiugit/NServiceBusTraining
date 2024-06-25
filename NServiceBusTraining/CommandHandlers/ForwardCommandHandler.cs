using NServiceBusTraining.Commands;

namespace NServiceBusTraining.CommandHandlers;

public class ForwardCommandHandler : IHandleMessages<ForwardCommand>
{
    public Task Handle(ForwardCommand message, IMessageHandlerContext context)
    {
        Console.WriteLine($"Received command with text: {message.Text}");

        return Task.CompletedTask;
    }
}

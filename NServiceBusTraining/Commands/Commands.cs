namespace NServiceBusTraining.Commands;

public record ExampleCommand(string Text) : ICommand;
public record ForwardCommand(string Text) : ICommand;

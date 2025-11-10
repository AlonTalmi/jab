namespace JabTests;

internal interface IPublisher<T>
{
}

internal class MessageBroker<T> : IPublisher<T>
{
}

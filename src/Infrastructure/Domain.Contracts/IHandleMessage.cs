namespace Domain.Contracts
{
    public interface IHandleMessage<in T>
    {
        void Handle(T message);
    }
}

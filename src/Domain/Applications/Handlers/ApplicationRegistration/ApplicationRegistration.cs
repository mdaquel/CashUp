using CashUp.Domain.Applications.Commands;
using Domain.Contracts;

namespace ApplicationRegistration
{
    public class ApplicationRegistration : IHandleMessage<PlaceApplication>
    {
        public void Handle(PlaceApplication message)
        {
            throw new System.NotImplementedException();
        }
    }
}

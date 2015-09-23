using CashUp.Domain.Applications.Events;
using Domain.Contracts;

namespace CashUp.Domain.Applications.Handlers
{
    public class ApplicationAssessment : IHandleMessage<ApplicationPlaced>
    {
        public void Handle(ApplicationPlaced message)
        {
            throw new System.NotImplementedException();
        }
    }
}

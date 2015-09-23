using CashUp.Domain.Applications.Commands;
using CashUp.Domain.Applications.Handlers;
using Machine.Specifications;

namespace Applications.Tests
{

    [Tags("Domain: Handlers")]
    [Subject(typeof(ApplicationRegistration))]
    public class When_handling_PlaceApplication_command
    {
        Establish context = () =>
        {
            Command = new PlaceApplication();
            SUT = new ApplicationRegistration();
        };

        static ApplicationRegistration SUT;
        static PlaceApplication Command;
    }
}

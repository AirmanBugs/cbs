
using Concepts.DataCollector;
using Dolittle.Commands;

namespace Domain.DataCollector.PhoneNumber
{
    public class RemovePhoneNumberFromDataCollector : ICommand
    {
        public DataCollectorId DataCollectorId { get; set; }
        public string PhoneNumber { get; set; }
    }
}
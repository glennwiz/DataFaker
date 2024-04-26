using Bogus;
using Newtonsoft.Json;

namespace DummyDataGeneration
{
    class Program
    {
        static void Main(string[] args)
        {
            var customerClients = new Faker<CustomerClient>()
                .StrictMode(true)
                .RuleFor(c => c.CustomerId, f => Guid.NewGuid().ToString())
                .RuleFor(c => c.CustomerGroups, f => new List<string>()) // Empty list as specified
                .RuleFor(c => c.FirstName, f => f.Name.FirstName())
                .RuleFor(c => c.LastName, f => f.Name.LastName())
                .RuleFor(c => c.FullName, (f, c) => $"{c.FirstName} {c.LastName}")
                .RuleFor(c => c.Email, (f, c) => f.Internet.Email(c.FirstName, c.LastName))
                .RuleFor(c => c.Phone, f => f.Phone.PhoneNumber("474#######"))
                .RuleFor(c => c.LastOrder, f => null) // Always null as specified
                .RuleFor(c => c.QrCode, f => new QrCode
                {
                    Value = $"STU_V2_{Guid.NewGuid()}___{f.Date.Future().ToUniversalTime().Ticks}_{Guid.NewGuid()}",
                    Expiry = f.Date.Future().ToUniversalTime().Ticks
                })
                .RuleFor(c => c.CustomerClientCards, f => new List<string>())
                .RuleFor(c => c.CustomerLoyaltyPrograms, f => new List<string>())
                .RuleFor(c => c.RewardPrograms, f => new List<string>());

            var customerList = customerClients.Generate(100); // Generate 100 customer client objects

            Console.WriteLine(JsonConvert.SerializeObject(customerList));
        }

        public class CustomerClient
        {
            public string CustomerId { get; set; }
            public List<string> CustomerGroups { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string FullName { get; set; }
            public string Email { get; set; }
            public string Phone { get; set; }
            public object LastOrder { get; set; }
            public QrCode QrCode { get; set; }
            public List<string> CustomerClientCards { get; set; }
            public List<string> CustomerLoyaltyPrograms { get; set; }
            public List<string> RewardPrograms { get; set; }
        }

        public class QrCode
        {
            public string Value { get; set; }
            public long Expiry { get; set; }
        }
    }
}
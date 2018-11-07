using Bogus;
using TechnicalTest.Models;

namespace TechnicalTest.Generators
{
    class SignupDetailsGenerator : IGenerator<SignupDetails>
    {
        private readonly Faker<SignupDetails> faker;
        public SignupDetailsGenerator()
        {
            this.faker = new Faker<SignupDetails>()
                .RuleFor(f => f.UserName, f => f.Name.FirstName())
                .RuleFor(f => f.Email, f => f.Internet.Email())
                .RuleFor(f => f.Password, f => f.Internet.Password());
        }
        public SignupDetails Generate()
        {
            return this.faker.Generate();
        }
    }
}

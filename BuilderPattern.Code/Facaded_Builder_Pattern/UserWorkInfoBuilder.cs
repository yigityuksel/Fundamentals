using BuilderPattern.Code.Models;

namespace BuilderPattern.Code.Facaded_Builder_Pattern
{
    public class UserWorkInfoBuilder : UserBuilder
    {

        public UserWorkInfoBuilder(User user)
        {
            User = user;
        }

        public UserWorkInfoBuilder At(string companyName)
        {
            User.CompanyName = companyName;
            return this;
        }

        public UserWorkInfoBuilder As(string position)
        {
            User.Position = position;
            return this;
        }

        public UserWorkInfoBuilder Income(int annualIncome)
        {
            User.AnnualIncome = annualIncome;
            return this;
        }
    }
}
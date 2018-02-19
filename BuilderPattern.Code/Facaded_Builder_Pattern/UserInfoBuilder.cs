using BuilderPattern.Code.Models;

namespace BuilderPattern.Code.Facaded_Builder_Pattern
{
    public class UserInfoBuilder : UserBuilder
    {

        public UserInfoBuilder(User user)
        {
            User = user;
        }

        public UserInfoBuilder At(string address)
        {
            User.Address = address;
            return this;
        }

        public UserInfoBuilder WithPostCode(string postCode)
        {
            User.PostCode = postCode;
            return this;
        }

        public UserInfoBuilder WithPhoneNumber(string phoneNumber)
        {
            User.PhoneNumber = phoneNumber;
            return this;
        }

    }
}
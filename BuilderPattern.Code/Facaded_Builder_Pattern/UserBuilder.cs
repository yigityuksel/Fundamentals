using BuilderPattern.Code.Models;

namespace BuilderPattern.Code.Facaded_Builder_Pattern
{
    public class UserBuilder
    {
        //reference
        protected User User = new User();

        public UserWorkInfoBuilder Works => new UserWorkInfoBuilder(User);

        public UserInfoBuilder Lives => new UserInfoBuilder(User);

        public static implicit operator User(UserBuilder ub)
        {
            return ub.User;
        }

    }
}
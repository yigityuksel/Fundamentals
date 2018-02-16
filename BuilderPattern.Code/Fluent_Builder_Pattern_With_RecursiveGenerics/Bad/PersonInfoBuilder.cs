using BuilderPattern.Code.Models;

namespace BuilderPattern.Code.Fluent_Builder_Pattern_With_RecursiveGenerics.Bad
{
    public class PersonInfoBuilder
    {
        protected Person person = new Person();

        public PersonInfoBuilder Called(string name)
        {
            person.Name = name;
            return this;
        }

    }
}

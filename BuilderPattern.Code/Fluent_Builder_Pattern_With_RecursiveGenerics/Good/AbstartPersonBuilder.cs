using BuilderPattern.Code.Models;

namespace BuilderPattern.Code.Fluent_Builder_Pattern_With_RecursiveGenerics.Good
{
    public class AbstartPersonBuilder
    {
        protected Person person = new Person();

        public Person Build()
        {
            return person;
        }

    }
}
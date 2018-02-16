namespace BuilderPattern.Code.Fluent_Builder_Pattern_With_RecursiveGenerics.Bad
{
    public class PersonJobBuilder : PersonInfoBuilder
    {
        public PersonJobBuilder WorksAsA(string position)
        {
            person.Position = position;
            return this;
        }
    }
}
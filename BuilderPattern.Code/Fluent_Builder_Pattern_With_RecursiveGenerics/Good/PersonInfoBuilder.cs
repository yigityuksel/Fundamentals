using BuilderPattern.Code.Models;

namespace BuilderPattern.Code.Fluent_Builder_Pattern_With_RecursiveGenerics.Good
{
    //where inhereting this object itself, recursive!
    public class PersonInfoBuilder<SELF> : AbstartPersonBuilder where SELF : PersonInfoBuilder<SELF>
    {
        public SELF Called(string name)
        {
            person.Name = name;
            return (SELF)this;
        }

    }
}

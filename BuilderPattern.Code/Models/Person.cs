using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuilderPattern.Code.Fluent_Builder_Pattern_With_RecursiveGenerics.Good;

namespace BuilderPattern.Code.Models
{
    public class Person
    {
        public string Name { get; set; }

        public string Position { get; set; }

        public override string ToString()
        {
            return $"{nameof(Name)} : {Name}, {nameof(Position)} : {Position}";
        }

        public class Builder : PersonJobBuilder<Builder>
        {

        }

        public static Builder New => new Builder();

    }
}

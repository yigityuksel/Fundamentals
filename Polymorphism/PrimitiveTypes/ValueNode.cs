using Polymorphism.AbstractTypes;

namespace Polymorphism.PrimitiveTypes
{
    public class ValueNode : Node
    {
        public double Value { get; set; }

        public override double Evaluate()
        {
            return Value;
        }
    }
}

namespace Polymorphism.AbstractTypes
{
    public abstract class OperationNode : Node
    {
        public Node LeftNode { get; set; }
        public Node RigthNode { get; set; }

        public abstract override double Evaluate();
    }
}

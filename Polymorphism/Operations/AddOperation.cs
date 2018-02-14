using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Polymorphism.AbstractTypes;

namespace Polymorphism.Operations
{
    public class AddOperation : OperationNode
    {
        public override double Evaluate()
        {
            return LeftNode.Evaluate() + RigthNode.Evaluate();
        }
    }
}

using FunctionalCalculator.Operators;

namespace FunctionalCalculator
{
    public abstract class MathOperation: IOperator
    {
        public readonly int LeftNode;
        public readonly int RightNode;
        public MathOperation(int x, int y)
            => (LeftNode, RightNode) = (x, y);
        public abstract int Evaluate();
    }
}

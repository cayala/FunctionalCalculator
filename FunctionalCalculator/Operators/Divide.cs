using System;

namespace FunctionalCalculator.Operators
{
    public class Divide: MathOperation
    {
        public Divide(int x, int y) : base(x, y) { }

        public override int Evaluate()
        {
            if (RightNode == 0)
                throw new ArgumentException("Error, cannot divide by zero");
            else
                return LeftNode / RightNode;
        }
    }
}

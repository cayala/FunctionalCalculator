namespace FunctionalCalculator.Operators
{
    public class Divide: MathOperation
    {
        public Divide(int x, int y) : base(x, y) { }

        public override int Evaluate()
            => LeftNode / RightNode;
    }
}

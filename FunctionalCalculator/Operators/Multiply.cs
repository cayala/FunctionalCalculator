namespace FunctionalCalculator.Operators
{
    public class Multiply: MathOperation
    {
        public Multiply(int x, int y) : base(x, y) { }
        public override int Evaluate()
            => LeftNode * RightNode;
    }
}

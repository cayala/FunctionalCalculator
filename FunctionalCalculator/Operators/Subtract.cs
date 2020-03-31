namespace FunctionalCalculator
{
    public class Subtract : MathOperation
    {
        public Subtract(int x, int y) : base(x, y) { }
        public override int Evaluate()
            => LeftNode - RightNode;
    }
}

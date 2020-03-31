namespace FunctionalCalculator.Operators
{
    public class Add: MathOperation
    {
        public Add(int x, int y) : base(x, y) { }
        public override int Evaluate()
            => LeftNode + RightNode;
        //not sure if I should put base.LeftNode + base.RightNode
        //for more clarity that is where those values are coming from
    }
}

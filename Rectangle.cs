namespace FigureProject
{
    class Rectangle : Figure
    {
        private readonly double a;
        private readonly double b;

        public Rectangle(string name, double a, double b) : base(name)
        {
            this.a = a;
            this.b = b;
        }

        public override double Area
        {
            get
            {
                return a * b;
            }
        }

        public override void TryToPlaceSegmentInsideFigure(double segmLength)
        {
            throw new NotImplementedException();
        }
    }
}

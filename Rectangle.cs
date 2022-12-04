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

        public override bool CouldPlaceSegmentInsideFigure(double segmLength)
        {
            return segmLength <= Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
        }
    }
}

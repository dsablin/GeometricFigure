namespace FigureProject
{
    class Circle : Figure
    {
        private readonly double radius;

        public Circle(string name, double radius) : base(name)
        {
            this.radius = radius;
        }

        public override double Area
        {
            get
            {
                return Math.PI * Math.Sqrt(radius);
            }
        }

        public override void TryToPlaceSegmentInsideFigure(double segmLength)
        {
            throw new NotImplementedException();
        }
    }
}

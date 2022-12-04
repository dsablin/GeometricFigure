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
                return Math.PI * Math.Pow(radius, 2);
            }
        }

        public override bool CouldPlaceSegmentInsideFigure(double segmLength)
        {
            return segmLength <= radius * 2;
        }
    }
}

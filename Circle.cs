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

        public override void TryToPlaceSegmentInsideFigure(double segmLength)
        {
            bool could = segmLength <= radius * 2;

            Console.WriteLine($"The segment of the length '{segmLength}' {(could ? "could" : "couldn't")} be put into the {Name}");
        }
    }
}

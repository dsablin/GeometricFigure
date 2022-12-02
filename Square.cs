namespace FigureProject
{
    class Square : Figure
    {
        private readonly double a;

        public Square(string name, double a) : base(name)
        {
            this.a = a;
        }

        public override double Area
        {
            get
            {
                return Math.Pow(a, 2);
            }
        }

        public override void TryToPlaceSegmentInsideFigure(double segmLength)
        {

            bool could = segmLength <= Math.Sqrt(Math.Pow(a, 2));

            Console.WriteLine($"The segment of the length given {(could ? "could" : "couldn't")} be put into the {Name}");
        }
    }
}

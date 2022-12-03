namespace FigureProject
{
    class Segment : Figure
    {
        private readonly double length;

        public Segment(string name, double length) : base(name)
        {
            this.length = length;
        }

        public override double Area => throw new Exception("Error! Couldn't calculate area of one-dimensional object.");

        public override void TryToPlaceSegmentInsideFigure(double segmLength)
        {
            bool could = segmLength <= length;

            Console.WriteLine($"The segment of the length '{segmLength}' {(could ? "doesn't exceed" : "exceeds")} length of the current {Name}");
        }
    }
}

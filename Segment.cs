namespace FigureProject
{
    class Segment : Figure
    {
        private readonly double length;

        public Segment(string name, double length) : base(name)
        {
            this.length = length;
        }

        public override double Area => throw new Exception("Error! Couldn't calculate one-dimensional object's area.");

        public override void TryToPlaceSegmentInsideFigure(double segmLength)
        {
            throw new NotImplementedException();
        }
    }
}

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

        public override bool CouldPlaceSegmentInsideFigure(double segmLength)
        {
            return segmLength <= length;
        }
    }
}

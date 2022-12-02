namespace FigureProject
{
    class Point : Figure
    {
        private readonly double x1;
        private readonly double y1;

        public Point(string name, double x1, double y1) : base(name)
        {
            this.x1 = x1;
            this.y1 = y1;
        }

        public override double Area => throw new Exception("Error! Couldn't calculate one-dimensional object's area.");

        public override void TryToPlaceSegmentInsideFigure(double segmLength)
        {
            throw new NotImplementedException();
        }
    }
}

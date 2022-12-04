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

        public override bool CouldPlaceSegmentInsideFigure(double segmLength)
        {

            return segmLength <= a * Math.Sqrt(2);
        }
    }
}

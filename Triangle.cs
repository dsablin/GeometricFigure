namespace FigureProject
{
    class Triangle : Figure
    {
        private readonly double a;
        private readonly double b;
        private readonly double c;
        private readonly double x1;
        private readonly double y1;
        private readonly double x2;
        private readonly double y2;
        private readonly double x3;
        private readonly double y3;
        private readonly bool useCoords = false;

        public Triangle(string name, double a, double b, double c) : base(name)
        {
            if (a + b <= c || a + c <= b ||
                            b + c <= a)
                throw new Exception($"Invalid sides' length for {a}, {b}, {c}");
            else
            {
                this.a = a;
                this.b = b;
                this.c = c;
            }
        }

        public Triangle(
            string name,
            double x1, double y1,
            double x2, double y2,
            double x3, double y3)
            : base(name)
        {
            double n = x1 * (y2 - y3) + x2 * (y3 - y1) + x3 * (y1 - y2);
             if (n == 0)
                throw new Exception($"Incorrect corners' coordinates {x1}, {y1}, {x2}, {y2}, {x3}, {y3}");
            else
            {
                this.x1 = x1;
                this.y1 = y1;
                this.x2 = x2;
                this.y2 = y2;
                this.x3 = x3;
                this.y3 = y3;
            }

             useCoords = true;
        }

        public override double Area
        { 
            get
            {
                switch (useCoords)
                {
                    case false:
                        return GetTriangleAreaByThreeSides(a, b, c);

                    case true:
                        double sideA = GetSideLengthByCoords(x1, y1, x2, y2);
                        double sideB = GetSideLengthByCoords(x2, y2, x3, y3); 
                        double sideC = GetSideLengthByCoords(x3, y3, x1, y1); 

                        return GetTriangleAreaByThreeSides(sideA, sideB, sideC);

                    default:
                        throw new Exception("Necessary parameter 'useCoords' is missed.");
                }
            }
        }

        private static double GetSideLengthByCoords(double n1, double m1, double n2, double m2)
        {
            return Math.Sqrt(Math.Pow(n2 - n1, 2) + Math.Pow(m2 - m1, 2));
        }

        private static double GetTriangleAreaByThreeSides(double sA, double sB, double sC)
        {
            double perimeter;
            double area;
            perimeter = (sA + sB + sC) / 2;
            area = Math.Sqrt(perimeter * (perimeter - sA) * (perimeter - sB) * (perimeter - sC));
            return area;
        }

        public override bool CouldPlaceSegmentInsideFigure(double segmLength) 
        {
            switch (useCoords)
            {
                case false:
                    return IsSegmentInsideTriangle(a, b, c, segmLength);

                case true:
                    double sideA = GetSideLengthByCoords(x1, y1, x2, y2);
                    double sideB = GetSideLengthByCoords(x2, y2, x3, y3);
                    double sideC = GetSideLengthByCoords(x3, y3, x1, y1);

                    return IsSegmentInsideTriangle(sideA, sideB, sideC, segmLength);
            }
       }

        private static bool IsSegmentInsideTriangle(double a, double b, double c, double segmLength)
        {
            return segmLength <= Math.Max(Math.Max(a, b), c);      
        }
    }
}

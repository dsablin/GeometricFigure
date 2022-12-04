using System.Drawing;

namespace FigureProject
{
    class Program
    {
        static void Main()
        {
            double segmLength = 50;

            Figure figRef;

            Triangle Trg = new Triangle("TriangleBySides", 20, 50, 50);
            Triangle Trng = new Triangle("TriangleByCorners", 20, 10, 10, 40, 30, 30);
            Square Sqr = new Square("Square", 10);
            Rectangle Rect = new Rectangle("Rectangle", 25, 45);
            Circle Crc = new Circle("Circle", 20);
            Segment Seg = new Segment("Otrezok", 60);
            Point Pt = new Point("Tochka", 15, 25);

            figRef = Trg;
            ExamineFigure(segmLength, figRef);

            figRef.FigureColor = Color.Yellow;
            Console.WriteLine($"{figRef.Name} new {figRef.FigureColor}\n");

            figRef = Trng;
            ExamineFigure(segmLength, figRef);

            figRef = Sqr;
            ExamineFigure(segmLength, figRef);

            figRef = Rect;
            ExamineFigure(segmLength, figRef);

            figRef.FigureColor = Color.DarkGreen;
            Console.WriteLine($"{figRef.Name} new {figRef.FigureColor}\n");

            figRef = Crc;
            figRef.FigureColor = Color.DarkGreen;
            ExamineFigure(segmLength, figRef);

            Seg.FigureColor = Color.Blue;
            figRef = Seg;
            Console.WriteLine($"Figure name is {figRef.Name}");
            Console.WriteLine($"{figRef.Name} initial {figRef.FigureColor}\n");
            
            try {
                Console.WriteLine($"{figRef.Name} area = {figRef.Area}");
            } catch (Exception e) {
                Console.WriteLine($"An exception caught:\n{e}\n");
            }
            bool could = figRef.CouldPlaceSegmentInsideFigure(segmLength);
            Console.WriteLine($"The segment of the length '{segmLength}' {(could ? "could" : "couldn't")} be put into the {figRef.Name}\n");

            Pt.FigureColor = Color.IndianRed;
            figRef = Pt;
            Console.WriteLine($"Figure name is {figRef.Name}");
            Console.WriteLine($"{figRef.Name} initial {figRef.FigureColor}\n");
            
            try {
                Console.WriteLine($"{figRef.Name} area = {figRef.Area}");
            } catch (Exception e) {
                Console.WriteLine($"An exception caught:\n{e}\n");
            }

            try {
                figRef.CouldPlaceSegmentInsideFigure(segmLength);
            }
            catch (Exception e) {
                Console.WriteLine($"An exception caught:\n{e}\n");
            }

        }

        private static void ExamineFigure(double segmLength, Figure figRef)
        {
            bool could;
            Console.WriteLine($"Figure name is {figRef.Name}");
            Console.WriteLine($"{figRef.Name} area = {figRef.Area}");
            Console.WriteLine($"{figRef.Name} initial {figRef.FigureColor}\n");
            could = figRef.CouldPlaceSegmentInsideFigure(segmLength);
            Console.WriteLine($"The segment of the length '{segmLength}' {(could ? "could" : "couldn't")} be put into the {figRef.Name}\n");
        }
    }
}

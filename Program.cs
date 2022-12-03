using System.Drawing;

namespace FigureProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Figure figRef;

            Triangle Trg = new Triangle("TriangleBySides", 20, 50, 50);
            Triangle Trng = new Triangle("TriangleByCorners", 20, 10, 10, 40, 30, 30);
            Square Sqr = new Square("Square", 10);
            Rectangle Rct = new Rectangle("Rectangle", 8, 15);
            Circle Crc = new Circle("Circle", 20);
            Segment Seg = new Segment("Otrezok", 30);
            Point Pt = new Point("Tochka", 15, 25);

            figRef = Trg;
            Console.WriteLine($"{figRef.Name} area = {figRef.Area}");
            Console.WriteLine($"{figRef.Name} initial {figRef.FigureColor}\n");

            figRef.FigureColor = Color.Yellow;
            Console.WriteLine($"{figRef.Name} new {figRef.FigureColor}\n");

            figRef.TryToPlaceSegmentInsideFigure(50);
            Console.WriteLine();
            
            figRef = Trng;
            Console.WriteLine($"New triangle name is {figRef.Name}");
            Console.WriteLine($"{figRef.Name} area = {figRef.Area}");

            figRef.TryToPlaceSegmentInsideFigure(50);
        }
    }
}

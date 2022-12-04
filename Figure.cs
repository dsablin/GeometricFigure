using System.Drawing;

namespace FigureProject
{
    abstract class Figure
    {
        private string name;
        private Color color;

        public Figure(string name)
        {
            this.name = name;
            color = Color.Black;
        }

        public string Name 
        { 
            get { return name; }  
        }

        public abstract double Area { get; }

        public virtual Color FigureColor
        {
            get { return color; }
            set { color = value; }
        }

        public abstract bool CouldPlaceSegmentInsideFigure(double segmLength);
    }
}

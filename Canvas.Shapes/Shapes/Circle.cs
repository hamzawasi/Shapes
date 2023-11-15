using Canvas.Shapes.Widgets;
using Shapes.Helper;

namespace Canvas.Shapes.Shapes
{
    public class Circle : Widget<Circle>
    {
        public Circle(
            int xCoordinate,
            int yCoordinate,
            double radius)
            : base(xCoordinate, yCoordinate)
        {
            Radius = radius;
            Size = Math.Round(Math.PI * Math.Pow(Radius, 2), ShapesConstants.MaxDecimalPlaces);
        }

        public double Radius { get; set; }
    }
}

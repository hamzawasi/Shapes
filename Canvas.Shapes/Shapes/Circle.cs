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
            Size = Math.PI * Math.Pow(Radius, 2);
        }

        public double Radius { get; set; }

        public override string Draw()
        {
            Renderer.Append($"Size:{Math.Round(Size, ShapesConstants.MaxDecimalPlaces)} ");
            Renderer.Append($"(x:{XCoordinate}, y:{YCoordinate}) ");
            return Renderer.ToString();
        }
    }
}

using Canvas.Shapes.Widgets;
using Shapes.Helper;

namespace Canvas.Shapes.Shapes
{
    public class Ellipse : Widget<Ellipse>
    {
        public Ellipse(
            int xCoordinate,
            int yCoordinate,
            int horizontalDiameter,
            int verticalDiameter)
            : base(xCoordinate, yCoordinate)
        {
            HorizontalDiameter = horizontalDiameter;
            VerticalDiameter = verticalDiameter;
            Size = HorizontalDiameter * VerticalDiameter * Math.PI;
        }

        public int HorizontalDiameter { get; set; }
        public int VerticalDiameter { get; set; }

        public override string Draw()
        {
            Renderer.Append($"{Name} ");
            Renderer.Append($"Size:{Math.Round(Size, ShapesConstants.MaxDecimalPlaces)} ");
            Renderer.Append($"(Horizontal Diameter:{HorizontalDiameter}, Vertical Diameter:{VerticalDiameter}) ");
            Renderer.Append($"(x:{XCoordinate}, y:{YCoordinate}) ");
            return Renderer.ToString();
        }
    }
}

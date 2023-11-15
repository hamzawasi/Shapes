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
            Size = Math.Round(HorizontalDiameter * VerticalDiameter * Math.PI, ShapesConstants.MaxDecimalPlaces);
        }

        public int HorizontalDiameter { get; set; }
        public int VerticalDiameter { get; set; }

        protected override void OnDraw()
        {
            Renderer.Append($"(Horizontal Diameter:{HorizontalDiameter}, Vertical Diameter:{VerticalDiameter}) ");
        }
    }
}

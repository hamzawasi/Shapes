using Canvas.Shapes.Widgets;
using Shapes.Helper;

namespace Canvas.Shapes.Shapes
{
    public class Ellipse : Widget
    {
        public Ellipse()
        {
        }

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

        public override void PromptForAttributes()
        {
            base.PromptForAttributes();

            Console.WriteLine("Enter HorizontalDiameter: ");
            HorizontalDiameter = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter VerticalDiameter: ");
            VerticalDiameter = int.Parse(Console.ReadLine());
        }

        public override Widget CreateWidgetFromPrompt()
        {
            PromptForAttributes();
            return new Ellipse(XCoordinate, YCoordinate, HorizontalDiameter, VerticalDiameter);
        }
    }
}

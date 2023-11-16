using Canvas.Shapes.Widgets;

namespace Canvas.Shapes.Shapes
{
    public class Rectangle : Square
    {
        public Rectangle()
        {
        }

        public Rectangle(
            int xCoordinate,
            int yCoordinate,
            int height,
            int width)
            : base(xCoordinate, yCoordinate, height, width)
        {
        }

        protected override void OnDraw()
        {
            Renderer.Append($"(Height:{Height}, Width:{Width}) ");
        }

        public override void PromptForAttributes()
        {
            base.PromptForAttributes();
        }

        public override Rectangle CreateWidgetFromPrompt()
        {
            PromptForAttributes();
            return new Rectangle(XCoordinate, YCoordinate, Height, Width);
        }
    }
}

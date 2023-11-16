using Shapes.Helper;

namespace Canvas.Shapes.Shapes
{
    public class TextBox : Rectangle
    {
        public TextBox()
        {
        }

        public TextBox(
            int xCoordinate,
            int yCoordinate,
            int height,
            int width,
            string backgroundColour,
            string? text = null)
            : base(xCoordinate, yCoordinate, height, width)
        {
            Text = text;
            BackgroundColour = string.IsNullOrEmpty(text) ? ShapesConstants.DefaultTextBoxBackgroundColour : backgroundColour;
        }

        public string BackgroundColour { get; set; }
        public string Text { get; set; }

        protected override void OnDraw()
        {
            Renderer.Append($"(Height:{Height}, Width:{Width}) ");
            Renderer.Append($"Background Colour:{BackgroundColour} ");
            Renderer.Append($"Text:{Text} ");
        }

        public override void PromptForAttributes()
        {
            base.PromptForAttributes();

            Console.WriteLine("Enter Text: ");
            Text = Console.ReadLine();

            Console.WriteLine("Enter BackgroundColour: ");
            BackgroundColour = Console.ReadLine();
        }

        public override TextBox CreateWidgetFromPrompt()
        {
            PromptForAttributes();
            return new TextBox(XCoordinate, YCoordinate, Height, Width, BackgroundColour, Text);
        }
    }
}

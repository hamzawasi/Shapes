using Shapes.Helper;

namespace Canvas.Shapes.Shapes
{
    public class TextBox : Rectangle
    {
        public TextBox(
            int xCoordinate,
            int yCoordinate,
            int height,
            int width,
            string backgroundColour,
            string? text = null)
            : base(xCoordinate, yCoordinate, height, width)
        {
            SetName(nameof(TextBox));
            Text = text;
            BackgroundColour = string.IsNullOrEmpty(text) ? ShapesConstants.DefaultTextBoxBackgroundColour : backgroundColour;
        }

        public string BackgroundColour { get; set; }
        public string Text { get; set; }

        public override string Draw()
        {
            Renderer.Append($"{Name} ");
            Renderer.Append($"Size:{Size} ");
            Renderer.Append($"(x:{XCoordinate}, y:{YCoordinate}) ");
            Renderer.Append($"(Height:{Height}, Width:{Width}) ");
            Renderer.Append($"Background Colour:{BackgroundColour} ");
            Renderer.Append($"Text:{Text} ");
            return Renderer.ToString();
        }
    }
}

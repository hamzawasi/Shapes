namespace Canvas.Shapes.Shapes
{
    public class Rectangle : Square
    {
        public Rectangle(
            int xCoordinate,
            int yCoordinate,
            int height,
            int width)
            : base(xCoordinate, yCoordinate)
        {
            SetName(nameof(Rectangle));
            Height = height;
            Width = width;
        }

        public int Height { get; set; }
        public int Width { get; set; }

        public override string Draw() 
        {
            Renderer.Append($"{Name} ");
            Renderer.Append($"Size:{Size} ");
            Renderer.Append($"(x:{XCoordinate}, y:{YCoordinate}) ");
            Renderer.Append($"(Height:{Height}, Width:{Width}) ");
            return Renderer.ToString();
        }
    }
}

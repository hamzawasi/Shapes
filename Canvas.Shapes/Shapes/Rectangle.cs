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
            Height = height;
            Width = width;
        }

        public int Height { get; set; }
        public int Width { get; set; }

        protected override void OnDraw()
        {
            Renderer.Append($"(Height:{Height}, Width:{Width}) ");
        }
    }
}

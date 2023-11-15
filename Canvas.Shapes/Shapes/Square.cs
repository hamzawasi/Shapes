using Canvas.Shapes.Widgets;

namespace Canvas.Shapes.Shapes
{
    public class Square : Widget<Square>
    {
        public Square(
            int xCoordinate, 
            int yCoordinate) 
            : base(xCoordinate, yCoordinate)
        {
            Size = xCoordinate * yCoordinate;
        }

        public override string Draw()
        {
            Renderer.Append($"{Name} ");
            Renderer.Append($"Size:{Size} ");
            Renderer.Append($"(x:{XCoordinate}, y:{YCoordinate}) ");
            return Renderer.ToString();
        }
    }
}

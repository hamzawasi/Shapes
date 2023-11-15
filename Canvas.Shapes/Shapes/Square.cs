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
    }
}

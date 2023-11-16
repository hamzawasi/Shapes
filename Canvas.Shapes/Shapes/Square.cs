using Canvas.Shapes.Widgets;

namespace Canvas.Shapes.Shapes
{
    public class Square : Widget
    {
        public Square()
        {
        }

        public Square(
            int xCoordinate,
            int yCoordinate,
            int height,
            int width)
            : base(xCoordinate, yCoordinate)
        {
            Height = height;
            Width = width;
            Size = Height * Width;
        }

        public int Height { get; set; }
        public int Width { get; set; }

        public override void PromptForAttributes()
        {
            base.PromptForAttributes();

            Console.WriteLine("Enter Height: ");
            Height = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Width: ");
            Width = int.Parse(Console.ReadLine());
        }

        public override Square CreateWidgetFromPrompt()
        {
            PromptForAttributes();
            return new Square(XCoordinate, YCoordinate, Height, Width);
        }
    }
}

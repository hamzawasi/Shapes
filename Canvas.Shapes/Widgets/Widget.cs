using System.Text;

namespace Canvas.Shapes.Widgets
{
    public abstract class Widget<TShape> : IWidget
        where TShape : Widget<TShape>
    {
        public Widget(
            int xCoordinate,
            int yCoordinate)
        {
            XCoordinate = xCoordinate;
            YCoordinate = yCoordinate;
            Name = this.GetType().Name;
            Renderer = new StringBuilder();
        }

        public string Name { get; set; }
        public int XCoordinate { get; set; }
        public int YCoordinate { get; set; }
        public double Size { get; set; }

        public StringBuilder Renderer { get; set; }

        protected virtual void OnDraw()
        {
        }

        public virtual string Draw()
        {
            Renderer.Append($"{Name} ");
            Renderer.Append($"Size:{Size} ");
            Renderer.Append($"(x:{XCoordinate}, y:{YCoordinate}) ");
            OnDraw();
            return Renderer.ToString();
        }
    }
}

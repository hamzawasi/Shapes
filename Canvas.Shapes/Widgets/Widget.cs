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
            Name = typeof(TShape).Name;
            Renderer = new StringBuilder();
            Renderer.Append($"{Name} ");
        }

        public string Name { get; set; }
        public int XCoordinate { get; set; }
        public int YCoordinate { get; set; }
        public double Size { get; set;  }

        public StringBuilder Renderer { get; set; }

        public void SetName(string name)
            => Name = name;

        public virtual string Draw()
            => Renderer.ToString();
    }
}

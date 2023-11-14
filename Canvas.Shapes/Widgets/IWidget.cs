using System.Text;

namespace Canvas.Shapes.Widgets
{
    public interface IWidget
    {
        string Name { get; set; }
        StringBuilder Renderer { get; set; }
        int XCoordinate { get; set; }
        int YCoordinate { get; set; }
        double Size { get; set; }

        string Draw();
    }
}
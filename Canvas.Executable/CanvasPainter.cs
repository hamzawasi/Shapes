using Canvas.Shapes.Shapes;
using Canvas.Shapes.Widgets;
using Shapes.Helper;

namespace Canvas.Executable
{
    public class CanvasPainter : ICanvasPainter
    {
        private readonly List<Widget> widgets = new List<Widget>();

        public void GreetUser()
        {
            Console.WriteLine("This widget can print the following shapes:");
            foreach (string shape in ShapesConstants.Shapes)
            {
                Console.WriteLine(shape);
            }
        }

        public void PromptForWidgets()
        {
            Console.WriteLine("How many widgets do you want to add to the canvas?");
            int totalWidgets = int.Parse(Console.ReadLine());

            for (int i = 0; i < totalWidgets; i++)
            {
                Console.WriteLine($"Choose type for widget {i + 1}:");
                string widgetType = Console.ReadLine();

                Widget widget = CreateWidgetFromUserPrompt(widgetType);
                if (widget != null)
                {
                    widgets.Add(widget);
                }
            }
        }

        public void PrintCanvas()
        {
            Console.WriteLine("Result: ");
            widgets.ForEach(w => Console.WriteLine(w.Draw()));
        }

        private Widget CreateWidgetFromUserPrompt(string widgetType)
        {
            switch (widgetType.ToLower())
            {
                case "square":
                    return new Square().CreateWidgetFromPrompt();
                case "rectangle":
                    return new Rectangle().CreateWidgetFromPrompt();
                case "circle":
                    return new Circle().CreateWidgetFromPrompt();
                case "ellipse":
                    return new Ellipse().CreateWidgetFromPrompt();
                case "textbox":
                    return new TextBox().CreateWidgetFromPrompt();
                default:
                    Console.WriteLine("Invalid widget selected");
                    return null;
            }
        }
    }
}

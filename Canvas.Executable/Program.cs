using Canvas.Executable;
using Microsoft.Extensions.DependencyInjection;
using Shapes.Helper;

ServiceCollection serviceCollection = new ServiceCollection();
serviceCollection.AddAllTypes<ICanvasPainter>();
ServiceProvider provider = serviceCollection.BuildServiceProvider();

CanvasPainter canvasPainter = provider.GetRequiredService<CanvasPainter>();

canvasPainter.GreetUser(); ;
canvasPainter.PromptForWidgets();;
canvasPainter.PrintCanvas();
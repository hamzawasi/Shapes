using Canvas.Shapes.Shapes;

var square = new Square(10, 10);
Console.WriteLine(square.Draw());

var rectangle = new Rectangle(10, 10, 5, 5);
Console.WriteLine(rectangle.Draw());

var circle = new Circle(10, 10, 5.25);
Console.WriteLine(circle.Draw());

var ellipse = new Ellipse(10, 10, 5, 5);
Console.WriteLine(ellipse.Draw());

var textBox1 = new TextBox(10, 10, 5, 5, "Blue");
Console.WriteLine(textBox1.Draw());

var textBox2 = new TextBox(10, 10, 5, 5, "Blue", "Hello");
Console.WriteLine(textBox2.Draw());
using Canvas.Shapes.Shapes;
using FluentAssertions;

namespace Shapes.Tests
{
    public class ShapesTests
    {
        [Theory]
        [InlineData(5, 5, 25)]
        [InlineData(-5, -5, 25)]
        public void Square_Validate_Size(int height, int width, double actualSize)
        {
            //Arrange
            int xCoordinate = 5;
            int yCoordinate = 5;

            //Act
            Square square = new(xCoordinate, yCoordinate, height, width);

            //Assert
            square.Height.Should().Be(height);
            square.Width.Should().Be(width);
            square.Size.Should().Be(actualSize);
        }

        [Theory]
        [InlineData(5, 5, 25)]
        [InlineData(-5, -5, 25)]
        public void Rectangle_Validate_Size(int height, int width, double actualSize)
        {
            //Arrange
            int xCoordinate = 5;
            int yCoordinate = 5;

            //Act
            Rectangle rectangle = new(xCoordinate, yCoordinate, height, width);

            //Assert
            rectangle.Height.Should().Be(height);
            rectangle.Width.Should().Be(width);
            rectangle.Size.Should().Be(actualSize);
        }

        [Theory]
        [InlineData(5, 78.54)]
        [InlineData(-5, 78.54)]
        public void Circle_Validate_Size(double radius, double actualSize)
        {
            //Arrange
            int xCoordinate = 5;
            int yCoordinate = 5;

            //Act
            Circle circle = new(xCoordinate, yCoordinate, radius);

            //Assert
            circle.Radius.Should().Be(radius);
            circle.Size.Should().Be(actualSize);
        }
        
        [Theory]
        [InlineData(5, 5, 78.54)]
        [InlineData(-5, -5, 78.54)]
        public void Ellipse_Validate_Size(int horizontalDiameter, int verticalDiameter, double actualSize)
        {
            //Arrange
            int xCoordinate = 5;
            int yCoordinate = 5;

            //Act
            Ellipse ellipse = new(xCoordinate, yCoordinate, horizontalDiameter, verticalDiameter);

            //Assert
            ellipse.HorizontalDiameter.Should().Be(horizontalDiameter);
            ellipse.VerticalDiameter.Should().Be(verticalDiameter);
            ellipse.Size.Should().Be(actualSize);
        }
        
        [Theory]
        [InlineData(5, 5, "Green", 25)]
        [InlineData(-5, -5, "Green", 25)]
        public void Textbox_Validate_Size(int height, int width, string backgroundColour, double actualSize)
        {
            //Arrange
            int xCoordinate = 5;
            int yCoordinate = 5;

            //Act
            TextBox textbox = new(xCoordinate, yCoordinate, height, width, backgroundColour);

            //Assert
            textbox.Height.Should().Be(height);
            textbox.Width.Should().Be(width);
            textbox.Size.Should().Be(actualSize);
        }

        [Theory]
        [InlineData(5, 5, "Green", "Hello", 25)]
        [InlineData(-5, -5, "Red", null, 25)]
        public void Textbox_Validate_Background_And_Text(int height, int width, string backgroundColour, string text, double actualSize)
        {
            //Arrange
            int xCoordinate = 5;
            int yCoordinate = 5;

            //Act
            TextBox textbox = new(xCoordinate, yCoordinate, height, width, backgroundColour, text);

            //Assert
            textbox.BackgroundColour.Should().Be(backgroundColour);
            textbox.Text.Should().Be(text);
            textbox.Size.Should().Be(actualSize);
        }
    }
}
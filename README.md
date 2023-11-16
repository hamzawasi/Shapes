# Shapes

[![.NET](https://github.com/hamzawasi/Shapes/actions/workflows/Canvas.yml/badge.svg)](https://github.com/hamzawasi/Shapes/actions/workflows/Canvas.yml)

## Project Structure

#### Canvas.Executable
This project contains the console application which hosts the CanvasPainter class.

#### Canvas.Helper
Contains helper files for the solution such as extensions, constants.

#### Canvas.Shapes
Contains models for shapes.

#### Canvas.Tests
xUnit based test project which contains unit tests for the shapes.

#### Workflows
Yaml workflow file which builds the solution and runs tests.

## Improvement Suggestions
- Shapes could have further abstractions based on their classes. For example a base class Parallelogram from which both Square and Rectangle could be derived.
- All shapes can be injected through DI.
- Canvas painter inputs should be validated for parsing, range (e.g int64 for larger numbers, null values etc.)
- Unit tests to test for exceptions, out of range scenarios.

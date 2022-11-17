using GeometricFigures.Figures;

namespace GeometricFigures.Factory
{
    public class FigureFactory
    {
        public FigureFactory() { }

        public Triangle CreateTriangle(double firstSide, double secondSide, double tghirdSide)
        {
            var triangle = new Triangle(firstSide, secondSide, tghirdSide);
            triangle.ThrowIfNotValid();

            return triangle;
        }

        public Circle CreateCircle(double radius)
        {
            var circle = new Circle(radius);
            circle.ThrowIfNotValid();

            return circle;
        }
    }
}

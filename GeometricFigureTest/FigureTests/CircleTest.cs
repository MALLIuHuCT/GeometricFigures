using GeometricFigures.Factory;


namespace GeometricFigureTest.FigureTests
{
    public class CircleTest
    {
        [Fact]
        public void MustReturnExceptionIfRadiuslessThanZero()
        {
            double radius = -5;

            var creatingCircle = new Action(() =>
            {
                new FigureFactory().CreateCircle(radius);
            });

            Assert.Throws<ArgumentException>(creatingCircle);
        }

        [Fact]
        public void MustReturnCorrectSquare()
        {
            int radius = 5;
            double square = Math.PI * radius * radius;

            var circle = new FigureFactory().CreateCircle(radius);

            Assert.Equal(square, circle.GetSquare());
        }
    }
}

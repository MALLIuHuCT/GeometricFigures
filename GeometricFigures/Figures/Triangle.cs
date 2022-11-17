using GeometricFigures.Interfaces;

namespace GeometricFigures.Figures
{
    public sealed class Triangle : AbstractFigure
    {
        private readonly double[] _sides;
        public bool IsRight
            => _sides.Sum(x => x * x) - 2 * Math.Pow(_sides.Max(), 2) == 0;

        internal Triangle(double firstSide, double secondSide, double thirdSide) 
            => _sides = new double[] { firstSide, secondSide, thirdSide };

        public override double GetSquare()
        {
            var semiPerimetr = _sides.Sum() / 2;


            var square = Math.Sqrt(semiPerimetr * _sides.Select(x => semiPerimetr - x)
                                                            .Aggregate((x, y) => x * y));

            return square;
        }

        internal override void ThrowIfNotValid()
        {
            if (_sides.Any(x => x <= 0))
                throw new ArgumentException("the sides cannot be negative");

            if (_sides.Sum() - _sides.Max() * 2 < 0)
                throw new ArgumentException("The sum of the two sides of a triangle is always greater than the third");
        }
    }
}

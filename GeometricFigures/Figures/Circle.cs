using GeometricFigures.Interfaces;

namespace GeometricFigures.Figures
{
    public sealed class Circle : AbstractFigure
    {
        private double _radius;

        internal Circle(double radius)
         => _radius = radius;

        public override double GetSquare()
            => Math.PI * Math.Pow(_radius, 2);

        internal override void ThrowIfNotValid()
        {
            if (_radius < 0)
                throw new ArgumentException("Radius can not be less than zero");
        }
    }
}

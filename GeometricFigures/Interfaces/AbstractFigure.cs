namespace GeometricFigures.Interfaces
{
    public abstract class AbstractFigure
    {
        public abstract double GetSquare();
        internal abstract void ThrowIfNotValid();
    }
}

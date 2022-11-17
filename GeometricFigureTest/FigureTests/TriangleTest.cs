using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using GeometricFigures.Factory;

namespace GeometricFigureTest.FigureTests
{
    public class TriangleTest
    {
        [Fact]
        public void MustReturnExceptionStatingThatSumOfTwoSidesMustBeGreaterThanTheThird()
        {
            double first, second, third;
            first = second = 2d;
            third = 5d;

            var creatingTriangle = new Action(() =>
            {
                new FigureFactory().CreateTriangle(first, second, third);
            });

            Assert.Throws<ArgumentException>(creatingTriangle);
        }

        [Fact]
        public void MustReturnExceptionStatingThatSidesMustBeGreaterThanZero()
        {
            double first, second, third;
            first = second = -2d;
            third = 4d;

            var creatingTriangle = new Action(() =>
            {
                new FigureFactory().CreateTriangle(first, second, third);
            });

            Assert.Throws<ArgumentException>(creatingTriangle);
        }

        [Fact]
        public void MustReturnCorrectSquare()
        {
            double first, second, third, square;

            first = 3;
            second = 4; 
            third= 5;
            double semiPerimetr = (first + second + third) / 2;
            square = Math.Sqrt(semiPerimetr * (semiPerimetr - first) * (semiPerimetr - second) * (semiPerimetr - third));

            var triangle = new FigureFactory().CreateTriangle(first, second, third);

            Assert.Equal(square, triangle.GetSquare());
            Assert.True(triangle.IsRight);
        }
    }
}

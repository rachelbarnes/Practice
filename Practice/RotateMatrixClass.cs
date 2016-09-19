using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
namespace Practice
{
    [TestFixture]
    class RotateMatrixClass
    {
        /*this method will rotate a matrix 90 degrees to the right
            it is assumed that the matrix is [4,4], however it would be just as easy to allow the user to put an input for count of the matrix

            this is a pretty crude workflow of this... the three for loops is pretty bad for efficiency, but it should work
            i'm not worried or concerned about the hardcoded 4 in here, it is a solution meant for a 4,4 matrix

            for debugging, it goes through line 23, goes to the first for loop and then just skips over... why does it skip over? 
        */

        public char[,] RotateMatrix(char[,] StartingMatrix)
        {
            char[,] RotateMatrix = new char[,] { };
            for (int k = 3; k < 1; k--)
            {
                for (int i = 0; i < 4; i++)
                {
                    for (int b = 0; b < 4; b++)
                    {
                        RotateMatrix[i, k] = StartingMatrix[i, b];
                    }
                }
            }
            return RotateMatrix; 
        }
    }

    [TestFixture]
    public class RotateMatrixTests
    {
        [Test]
        public void RotateMyMatrix()
        {
            var rotate = new RotateMatrixClass(); 
            char[,] StartingMatrix = new char[,] {
                {'a', 'b','c','d'},
                {'e','f','g','h' },
                {'i','j','k','l' },
                {'m','n','o','p' }
            };
            var expected = new char[,]
            {
                {'m','i','e','a' },
                {'n','j','f','b' },
                {'o','k','g','c' },
                {'p','l','h','d' }
            };
            var actual = rotate.RotateMatrix(StartingMatrix);
            Assert.AreEqual(expected, actual); 
        }
    }
}

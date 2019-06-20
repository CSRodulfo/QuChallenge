using NUnit.Framework;
using QuBeyond.Backend.Bussiness.Matrixes;
using QuBeyond.Backend.Services;
using System.Collections.Generic;
using System.Linq;

namespace QuBeyondTest
{
    public class UnitTestsMatrixQu
    {
        private IEnumerable<string> matrix;

        [SetUp]
        public void Setup()
        {
            matrix = new string[] {
                "abcdc",
                "fgwio",
                "chill",
                "pqnsd",
                "uvdxy",
            };
        }

        [Test]
        public void FindWord_Take()
        {
            Matrix myMatrix = new Matrix(matrix);

            IEnumerable<string> finderWord = myMatrix.FindWords(new string[] {
                "chill",
                "cold"
            });

            Assert.AreEqual(2, finderWord.Count());
        }

        [Test]
        public void FindWord_ContainsFirstWord()
        {
            Matrix myMatrix = new Matrix(matrix);

            var finderWord = myMatrix.FindWords(new string[] {
                "chill",
                "cold"
             });

            Assert.AreEqual("chill", finderWord.ToList().FirstOrDefault());
        }
    }
}
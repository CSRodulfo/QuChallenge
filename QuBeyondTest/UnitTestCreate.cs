using NUnit.Framework;
using QuBeyond.Backend.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuBeyondTest
{
   public class UnitTestCreate
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
        public void CreateWordFinder()
        {
            WordFinder wordFinder = new WordFinder(matrix);
            Assert.NotNull(matrix);
        }
    }
}

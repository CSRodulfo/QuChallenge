using NUnit.Framework;
using QuBeyond.Backend.Bussiness.Matrixes;
using QuBeyond.Backend.Services;
using System.Collections.Generic;
using System.Linq;

namespace QuBeyondTest
{
    public class UnitTestsMatrixMiddle
    {
        private IEnumerable<string> matrix;

        [SetUp]
        public void Setup()
        {
            matrix = new string[] {
                "RFXPIRMFXDIBBRY",
                "QVILPERROLHRUEM",
                "FKCQRTTLCNQGHKF",
                "HTIERRAMNNZBKPT",
                "SIDEWETPVENUSZH",
                "MOJYNXLVDYTJZSS",
                "EWUPNKWMXFCCWNR",
                "RUPJAMSATURNOCM",
                "CMILLSBYAQLSYCA",
                "UMTSSRCUJCNPSAR",
                "RJEHPBSFJCYITST",
                "IORTSBZFFHZRGAE",
                "OJUURANOQSFWMWT",
                "PHIILOFAVTLDZAK",
                "OXRLNEPTUNOYIPB",
            };
        }
        [Test]
        public void FindWord_Take()
        {
            Matrix myMatrix = new Matrix(matrix);

            var finderWord = myMatrix.FindWords(new string[] {
                "SATURNO",
                "URANO",
                "MERCURIO",
                "NEPTUNO",
                "TIERRA",
                "JUPITER",
                "MARTE",
                "VENUS",
                "PERRO",
                "CASA",
             });

            Assert.AreEqual(10, finderWord.Count());
        }

        [Test]
        public void FindWord_ContainsFirstWord()
        {
            Matrix myMatrix = new Matrix(matrix);

            var finderWord = myMatrix.FindWords(new string[] {
                "SATURNO",
                "URANO",
                "MERCURIO",
                "NEPTUNO",
                "TIERRA",
                "JUPITER",
                "MARTE",
                "VENUS",
                "PERRO",
                "CASA",
             });

            Assert.AreEqual("SATURNO", finderWord.ToList().FirstOrDefault());
        }
    }
}
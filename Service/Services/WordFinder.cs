using QuBeyond.Backend.Bussiness.Matrixes;
using QuBeyond.Backend.IServices;
using System.Collections.Generic;

namespace QuBeyond.Backend.Services
{
    public class WordFinder : IWordFinder
    {
        private IEnumerable<string> matrix;
        public WordFinder(IEnumerable<string> matrix)
        {
            this.matrix = matrix;
        }
        public IEnumerable<string> Find(IEnumerable<string> wordstream)
        {
            Matrix myMatrix = new Matrix(matrix);

            return myMatrix.FindWords(wordstream);
        }
    }
}

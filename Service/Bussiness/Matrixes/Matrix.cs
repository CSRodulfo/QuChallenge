using QuBeyond.Backend.Bussiness.Finds;
using System.Collections.Generic;

namespace QuBeyond.Backend.Bussiness.Matrixes
{
    public class Matrix
    {
        Search search = null;
        public Matrix(IEnumerable<string> matrix)
        {
            Vector vector = new Vector(matrix);
            this.search = new Search(vector);
        }

        public IEnumerable<string> FindWords(IEnumerable<string> wordstream)
        {
            return this.search.FindWords(wordstream);
        }
    }
}

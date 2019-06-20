using System.Collections.Generic;
using System.Linq;

namespace QuBeyond.Model
{
    public class QuMatrixModel
    {
        public IEnumerable<string> matrix;

        public IEnumerable<string> words;

        public bool Valid()
        {
            if (matrix.Count()== 0)
            {
                return false;
            }

            if (matrix.FirstOrDefault().Count() >= 64)
            {
                return false;
            }
            return true;
        }
    }
}

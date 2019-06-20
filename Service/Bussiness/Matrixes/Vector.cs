using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuBeyond.Backend.Bussiness.Matrixes
{
    public class Vector
    {
        private string vectorValue;

        private IEnumerable<string> matrix;

        public Vector(IEnumerable<string> matrix)
        {
            this.matrix = matrix;
        }

        public string GetVector()
        {
            int size = matrix.Count();

            for (int i = 0; i < size; i++)
            {
                this.BuilderVector(matrix.ElementAt(i));

                var builder = new StringBuilder();
                for (int j = 0; j < size; j++)
                {
                    char character = matrix.ElementAt(j).ElementAt(i);
                    builder.Append(character);
                }
                this.BuilderVector(builder.ToString());
            }

            return this.vectorValue;
        }

        private void BuilderVector(string rowColumn)
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(rowColumn);
            builder.Append("/");
            this.vectorValue += builder.ToString();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace QuBeyond.Backend.IServices
{
    public interface IWordFinder
    {
        IEnumerable<string> Find(IEnumerable<string> wordstream);
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CopyFilesApp
{
    public static class StringHelper
    {
        public static IEnumerable<string> GetLines(this string s)
        {
            using (var reader = new StringReader(s))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    yield return line;
                }
            }
        }
    }
}

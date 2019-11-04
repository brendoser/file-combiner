using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileCombiner.Data
{
    public class ListItemData
    {
        public string FilePath { get; set; }

        public string FileSize { get; set; }

        public string DateModified { get; set; }

        public ListItemData(string filePath, string fileSize, string dateModified)
        {
            FilePath = filePath;
            FileSize = fileSize;
            DateModified = dateModified;
        }
    }
}

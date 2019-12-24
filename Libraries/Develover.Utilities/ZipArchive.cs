using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Develover.Utilities
{
    public class ZipArchives
    {
        public void ArchiveDirectory(string pathZip, string pathOut)
        {
            ZipFile.CreateFromDirectory(pathZip, pathOut);
        }
        public void UnzipArchive(string pathExtract, string pathFileZip)
        {
            ZipFile.ExtractToDirectory(pathFileZip, pathExtract);
        }
      
    }
}

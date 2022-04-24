using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;

namespace AutoradioGui
{
    public class NameCorrector
    {
        public DirectoryInfo[] GetAllDirectories(string path)
        {
            //check for directory actually existing
            string s = Path.GetFullPath(path);
            DirectoryInfo info = new DirectoryInfo(s);
            if (!info.Exists)
            {
                return null;
            }
    
            //search all sub directories using win api
            List<DirectoryInfo> result = info.GetDirectories("*", SearchOption.AllDirectories).ToList();
            //Add parrent directory as result
            result.Insert(0,info);
            return result.ToArray();
        }

        public string CorrectName(string wrongName)
        {
            //normalize string to standard form
            string name = wrongName.Normalize(NormalizationForm.FormD);
            //select only standalone characters
            return new string(name.Where(x => char.GetUnicodeCategory(x) != UnicodeCategory.NonSpacingMark).ToArray());
        }

        public IEnumerable<string> CorrectDirectories(DirectoryInfo[] directoryInfos)
        {
            foreach (DirectoryInfo directoryInfo in directoryInfos)
            {
                yield return ($"{directoryInfo.FullName} -> {CorrectName(directoryInfo.Name)}");
                foreach (string s in CorrectFilesInDirectory(directoryInfo))
                {
                    yield return s;
                }
            }
        }

        public IEnumerable<string> CorrectFilesInDirectory(DirectoryInfo directoryInfo)
        {
            foreach (FileInfo file in directoryInfo.GetFiles())
            {
                yield return ($"{file.FullName} -> {CorrectName(file.Name)}");
            }
        }

    }
}
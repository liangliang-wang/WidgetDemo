using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class ContentFind
    {
        public string FindContent(string path, string content)
        {
            string result = string.Empty;
            var files = Directory.GetFiles(path,"*.xml");
            foreach (var item in files)
            {
                var text = Read(item);
                if (text.IndexOf(content) > 0)
                {
                    result += item + ";";
                }
            }
            var dics = Directory.GetDirectories(path);
            foreach (var item in dics)
            {
                var res = FindContent(item, content);
                result += res;
            }
            return result;
        }

        private string Read(string path)
        {
            var content = string.Empty;
            using (StreamReader sr = new StreamReader(path, Encoding.Default))
            {
                content = sr.ReadToEnd();
            }
            return content;
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    /// <summary>
    /// IO测试
    /// </summary>
    public class IOTest
    {
        public void Get(string path)
        {
            byte[] ss01 = Encoding.BigEndianUnicode.GetBytes("宋世杰");
            List<string> a01 = new List<string>();
            foreach (var s in ss01)
            {
                a01.Add(s.ToString("X"));
            }



            byte[] ss02 = Encoding.Unicode.GetBytes("宋世杰");
            List<string> a02 = new List<string>();
            foreach (var s in ss02)
            {
                a02.Add(s.ToString("X"));
            }


            byte[] ss03 = Encoding.UTF8.GetBytes("宋世杰");
            List<string> a03 = new List<string>();
            foreach (var s in ss03)
            {
                a03.Add(s.ToString("X"));
            }
        }


        /// <summary> 
        /// 给定文件的路径，读取文件的二进制数据，判断文件的编码类型 
        /// </summary> 
        /// <param name=“FILE_NAME“>文件路径</param> 
        /// <returns>文件的编码类型</returns> 
        public static Encoding GetType(string FILE_NAME)
        {
            FileStream fs = new FileStream(FILE_NAME, FileMode.Open, FileAccess.Read);
            Encoding r = GetType(fs);
            fs.Close();
            return r;
        } 

        /// <summary> 
        /// 通过给定的文件流，判断文件的编码类型 
        /// </summary> 
        /// <param name=“fs“>文件流</param> 
        /// <returns>文件的编码类型</returns> 
        public static System.Text.Encoding GetType(FileStream fs)
        {
            Encoding reVal = Encoding.Default;

            BinaryReader r = new BinaryReader(fs,Encoding.Default);
            int i;
            int.TryParse(fs.Length.ToString(), out i);
            byte[] ss = r.ReadBytes(i);
            foreach (var b in ss)
            {
                var s = Convert.ToString(b, 16);
            }
            r.Close();
            return reVal;

        } 
    }
}

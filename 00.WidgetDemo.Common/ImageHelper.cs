using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WidgetDemo.Common
{
    public class ImageHelper
    {
        //图片 转为    base64编码的文本
        public static string ImgToBase64String(string Imagefilename)
        {
            var result = string.Empty;
            try
            {
                System.Drawing.Bitmap bmp1 = new System.Drawing.Bitmap(Imagefilename);
                using (MemoryStream ms1 = new MemoryStream())
                {
                    bmp1.Save(ms1, System.Drawing.Imaging.ImageFormat.Jpeg);
                    byte[] arr1 = new byte[ms1.Length];
                    ms1.Position = 0;
                    ms1.Read(arr1, 0, (int)ms1.Length);
                    ms1.Close();
                    result = Convert.ToBase64String(arr1);
                }

            }
            catch (Exception ex)
            {
                result = string.Format("转换失败：{0}", ex.Message);
            }
            return result;
        }

        public static void Base64ToImg(string base64, string filePath, string fileName)
        {
            byte[] arr2 = Convert.FromBase64String(base64);
            using (MemoryStream ms2 = new MemoryStream(arr2))
            {
                var filedic = string.Format("{0}/{1}", filePath.Trim('/'), fileName);
                System.Drawing.Bitmap bmp2 = new System.Drawing.Bitmap(ms2);
                //bmp2.Save(filedic + ".jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
                //bmp2.Save(filePath + ".bmp", System.Drawing.Imaging.ImageFormat.Bmp);
                //bmp2.Save(filePath + ".gif", System.Drawing.Imaging.ImageFormat.Gif);
                bmp2.Save(filePath + ".png", System.Drawing.Imaging.ImageFormat.Png);
            }
        }
    }
}

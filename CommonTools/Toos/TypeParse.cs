using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CommonTools.Tools
{
    public static class TypeParse
    {
        /// <summary>string型转换为bool型</summary>
        /// <param name="input">要转换的字符串</param>
        /// <param name="defaultValue">缺省值</param>
        /// <returns>转换后的bool类型结果</returns>
        public static bool StringToBool(object input, bool defaultValue)
        {
            bool result;
            if (input != null && input != DBNull.Value)
            {
                if (string.Compare(input.ToString(), "true", true) == 0)
                {
                    result = true;
                    return result;
                }
                if (string.Compare(input.ToString(), "false", true) == 0)
                {
                    result = false;
                    return result;
                }
            }
            result = defaultValue;
            return result;
        }

        /// <summary>将对象转换为Int32类型</summary>
        /// <param name="input">要转换的字符串</param>
        /// <param name="defaultValue">缺省值</param>
        /// <returns>转换后的int类型结果</returns>
        public static int StringToInt(object input, int defaultValue)
        {
            int result;
            if (input != null && input != DBNull.Value)
            {
                result = TypeParse.StringToInt(input.ToString(), defaultValue);
            }
            else
            {
                result = defaultValue;
            }
            return result;
        }

        /// <summary>将对象转换为Int32类型</summary>
        /// <param name="input">要转换的字符串</param>
        /// <param name="defaultValue">缺省值</param>
        /// <returns>转换后的int类型结果</returns>
        public static int StringToInt(string input, int defaultValue)
        {
            int result;
            int num;
            if (string.IsNullOrEmpty(input) || input.Trim().Length >= 11 || !Regex.IsMatch(input.Trim(), "^([-]|[0-9])[0-9]*(\\.\\w*)?$"))
            {
                result = defaultValue;
            }
            else if (int.TryParse(input, out num))
            {
                result = num;
            }
            else
            {
                result = Convert.ToInt32(TypeParse.StringToFloat(input, (float)defaultValue));
            }
            return result;
        }

        /// <summary>将对象转换为Int64类型</summary>
        /// <param name="input">要转换的字符串</param>
        /// <param name="defaultValue">缺省值</param>
        /// <returns>转换后的int64类型结果</returns>
        public static long StringToInt64(object input, int defaultValue)
        {
            long result;
            if (input != null && input != DBNull.Value)
            {
                string text = input.ToString();
                if (text.Length > 0 && text.Length <= 22 && Regex.IsMatch(text, "^[-]?[0-9]*$"))
                {
                    if (text.Length < 20 || (text.Length == 20 && text[0] == '1') || (text.Length == 22 && text[0] == '-' && text[1] == '1'))
                    {
                        result = Convert.ToInt64(text);
                        return result;
                    }
                }
            }
            result = (long)defaultValue;
            return result;
        }

        /// <summary>string型转换为float型</summary>
        /// <param name="input">要转换的字符串</param>
        /// <param name="defaultValue">缺省值</param>
        /// <returns>转换后的int类型结果</returns>
        public static float StringToFloat(object input, float defaultValue)
        {
            float result;
            if (input == null || input == DBNull.Value)
            {
                result = defaultValue;
            }
            else
            {
                result = TypeParse.StringToFloat(input.ToString(), defaultValue);
            }
            return result;
        }

        /// <summary>string型转换为float型</summary>
        /// <param name="input">要转换的字符串</param>
        /// <param name="defaultValue">缺省值</param>
        /// <returns>转换后的int类型结果</returns>
        public static float StringToFloat(string input, float defaultValue)
        {
            float result;
            if (input == null || input.Length > 10)
            {
                result = defaultValue;
            }
            else
            {
                float num = defaultValue;
                bool flag = Regex.IsMatch(input, "^([-]|[0-9])[0-9]*(\\.\\w*)?$");
                if (flag)
                {
                    float.TryParse(input, out num);
                }
                result = num;
            }
            return result;
        }

        /// <summary>string型转换为decimal型</summary>
        /// <param name="input">源字符串</param>
        /// <param name="defaultValue">默认值</param>
        /// <returns>decimal型</returns>
        public static decimal StringToDecimal(string input, decimal defaultValue)
        {
            decimal result;
            if (string.IsNullOrWhiteSpace(input) || input.Length > 16)
            {
                result = defaultValue;
            }
            else
            {
                try
                {
                    decimal num = defaultValue;
                    decimal.TryParse(input, out num);
                    result = num;
                }
                catch (Exception innerException)
                {
                    throw new ArgumentException("string型转换为decimal型发生异常，传入值:" + input, innerException);
                }
            }
            return result;
        }

        /// <summary>过滤XML中换行和空白字符</summary>
        /// <param name="input">要过滤的字符串</param>
        /// <returns>过滤后的字符串</returns>
        public static string GetXmlClearSpace(string input)
        {
            string text = Regex.Replace(input, "[\\n\\r\\s]{2,}", "");
            return text.Trim();
        }

        /// <summary>string转换成时间格式</summary>
        /// <param name="input">日期</param>
        /// <param name="defaultValue">默认时间</param>
        /// <returns>时间</returns>
        public static DateTime StringToDateTime(string input, DateTime defaultValue)
        {
            DateTime minValue = DateTime.MinValue;
            DateTime result;
            if (DateTime.TryParse(input, out minValue))
            {
                result = minValue;
            }
            else
            {
                result = defaultValue;
            }
            return result;
        }

        /// <summary>BASE64编码(GB2312-80编码)</summary>
        /// <param name="input">需要编码的字符串</param>
        /// <returns>编码后的字符串</returns>
        public static string ToBase64(string input)
        {
            string result;
            if (string.IsNullOrEmpty(input))
            {
                result = "";
            }
            else
            {
                result = Convert.ToBase64String(Encoding.GetEncoding(20936).GetBytes(input));
            }
            return result;
        }

        /// <summary>BASE64解码(GB2312-80编码)</summary>
        /// <param name="input">需要解码的字符串</param>
        /// <returns>字符串</returns>
        public static string FromBase64(string input)
        {
            string result;
            if (string.IsNullOrEmpty(input))
            {
                result = "";
            }
            else
            {
                result = Encoding.GetEncoding(20936).GetString(Convert.FromBase64String(input));
            }
            return result;
        }

        /// <summary>将泛类型集合List类转换成DataTable</summary>
        /// <param name="inputs">泛类型集合</param>
        /// <returns>DataTable</returns>
        public static DataTable ListToDataTable<T>(List<T> inputs)
        {
            if (inputs == null || inputs.Count < 1)
            {
                throw new Exception("需转换的集合为空");
            }
            T t = inputs[0];
            Type type = t.GetType();
            PropertyInfo[] properties = type.GetProperties();
            DataTable dataTable = new DataTable();
            PropertyInfo[] array = properties;
            for (int i = 0; i < array.Length; i++)
            {
                PropertyInfo propertyInfo = array[i];
                dataTable.Columns.Add(propertyInfo.Name);
            }
            foreach (object obj in inputs)
            {
                if (obj.GetType() != type)
                {
                    throw new Exception("要转换的集合元素类型不一致");
                }
                object[] array2 = new object[properties.Length];
                for (int j = 0; j < properties.Length; j++)
                {
                    array2[j] = properties[j].GetValue(obj, null);
                }
                dataTable.Rows.Add(array2);
            }
            return dataTable;
        }

        /// <summary>将泛类型集合List类转换成DataTable，并指定列的类型</summary>
        /// <param name="inputs">泛类型集合</param>
        /// <returns>DataTable</returns>
        public static DataTable ListToDataTableWithColumnType<T>(List<T> inputs)
        {
            if (inputs == null || inputs.Count < 1)
            {
                throw new Exception("需转换的集合为空");
            }
            T t = inputs[0];
            Type type = t.GetType();
            PropertyInfo[] properties = type.GetProperties();
            DataTable dataTable = new DataTable();
            PropertyInfo[] array = properties;
            for (int i = 0; i < array.Length; i++)
            {
                PropertyInfo propertyInfo = array[i];
                dataTable.Columns.Add(propertyInfo.Name, propertyInfo.PropertyType);
            }
            foreach (object obj in inputs)
            {
                if (obj.GetType() != type)
                {
                    throw new Exception("要转换的集合元素类型不一致");
                }
                object[] array2 = new object[properties.Length];
                for (int j = 0; j < properties.Length; j++)
                {
                    array2[j] = properties[j].GetValue(obj, null);
                }
                dataTable.Rows.Add(array2);
            }
            return dataTable;
        }

        /// <summary>转换类型，返回是否转换成功</summary>
        /// <typeparam name="T">要转换的类型</typeparam>
        /// <param name="input">要转换的值</param>
        /// <param name="returnValue">返回的值</param>
        public static void TryConvert<T>(object input, out T returnValue)
        {
            returnValue = default(T);
            if (input != null)
            {
                Type type = typeof(T);
                if (type.IsGenericType)
                {
                    type = type.GetGenericArguments()[0];
                }
                if (type.Name.ToLower() == "datetime")
                {
                    DateTime? dateTime = new DateTime?(TypeParse.StringToDateTime(input.ToString(), DateTime.Parse("1900-01-01")));
                    object obj = dateTime.Value;
                    returnValue = (T)((object)obj);
                }
                if (type.Name.ToLower() == "string")
                {
                    object obj2 = input.ToString();
                    returnValue = (T)((object)obj2);
                }
                MethodInfo method = type.GetMethod("TryParse", BindingFlags.Static | BindingFlags.Public, Type.DefaultBinder, new Type[]
				{
					typeof(string),
					type.MakeByRefType()
				}, new ParameterModifier[]
				{
					new ParameterModifier(2)
				});
                object[] array = new object[]
				{
					input.ToString(),
					Activator.CreateInstance(type)
				};
                bool flag = (bool)method.Invoke(null, array);
                if (flag)
                {
                    returnValue = (T)((object)array[1]);
                }
            }
        }

        /// <summary>
        /// 转全角的函数(SBC case)
        /// 任意字符串
        /// 全角字符串
        /// 全角空格为12288，半角空格为32
        /// 其他字符半角(33-126)与全角(65281-65374)的对应关系是：均相差65248
        /// </summary>
        /// <param name="input">源字符串</param>
        /// <returns>全角字符串</returns>
        public static string ToSbc(string input)
        {
            char[] array = input.ToCharArray();
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == ' ')
                {
                    array[i] = '\u3000';
                }
                else if (array[i] < '\u007f')
                {
                    array[i] += 'ﻠ';
                }
            }
            return new string(array);
        }

        /// <summary>
        /// 转半角的函数(DBC case)
        /// 任意字符串
        /// 半角字符串
        /// 全角空格为12288，半角空格为32
        /// 其他字符半角(33-126)与全角(65281-65374)的对应关系是：均相差65248
        /// </summary>
        /// <param name="input">源字符串</param>
        /// <returns>半角字符串</returns>
        public static string ToDbc(string input)
        {
            char[] array = input.ToCharArray();
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == '\u3000')
                {
                    array[i] = ' ';
                }
                else if (array[i] > '＀' && array[i] < '｟')
                {
                    array[i] -= 'ﻠ';
                }
            }
            return new string(array);
        }
    }
}

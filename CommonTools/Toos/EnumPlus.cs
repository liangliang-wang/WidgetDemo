using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CommonTools.Tools
{
    /// <summary>枚举的扩展功能类</summary>
    public static class EnumPlus
    {
        /// <summary>获取枚举的描述信息</summary>
        /// <param name="e">源枚举</param>
        /// <returns>枚举的描述信息</returns>
        public static string GetEnumDescription(this Enum e)
        {
            FieldInfo field = e.GetType().GetField(e.ToString());
            DescriptionAttribute[] array = (DescriptionAttribute[])field.GetCustomAttributes(typeof(DescriptionAttribute), false);
            return (array.Length > 0) ? array[0].Description : e.ToString();
        }

        /// <summary>获取枚举的描述信息</summary>
        /// <param name="enumType">枚举类型</param>
        /// <param name="enumValue">枚举值</param>
        /// <returns>枚举的描述信息</returns>
        public static string GetEnumDescription(Type enumType, string enumValue)
        {
            string result = "";
            using (IEnumerator<Enum> enumerator = (from Enum e in Enum.GetValues(enumType)
                                                   where e.ToString() == enumValue
                                                   select e).GetEnumerator())
            {
                if (enumerator.MoveNext())
                {
                    Enum current = enumerator.Current;
                    result = current.GetEnumDescription();
                }
            }
            return result;
        }

        /// <summary>获取枚举的描述信息，根据传入的枚举值</summary>
        /// <param name="enumType">枚举类型</param>
        /// <param name="enumValue">枚举值</param>
        /// <returns>枚举的描述信息</returns>
        public static string GetEnumDescription(Type enumType, byte enumValue)
        {
            string result = "";
            using (IEnumerator<Enum> enumerator = (from Enum e in Enum.GetValues(enumType)
                                                   where Convert.ToInt32(e) == (int)enumValue
                                                   select e).GetEnumerator())
            {
                if (enumerator.MoveNext())
                {
                    Enum current = enumerator.Current;
                    result = current.GetEnumDescription();
                }
            }
            return result;
        }

        /// <summary>获取枚举的描述信息，根据传入的枚举值</summary>
        /// <param name="enumType">枚举类型</param>
        /// <param name="enumValue">枚举值</param>
        /// <returns>枚举的描述信息</returns>
        public static string GetEnumDescription(Type enumType, int enumValue)
        {
            string result = "";
            using (IEnumerator<Enum> enumerator = (from Enum e in Enum.GetValues(enumType)
                                                   where Convert.ToInt32(e) == enumValue
                                                   select e).GetEnumerator())
            {
                if (enumerator.MoveNext())
                {
                    Enum current = enumerator.Current;
                    result = current.GetEnumDescription();
                }
            }
            return result;
        }

        /// <summary>将含有描述信息的枚举绑定到字典中</summary>
        /// <param name="enumType">枚举类别</param>
        /// <returns>返回一个包含Key和Value的字典</returns>
        public static Dictionary<string, string> GetEnumKey(Type enumType)
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            foreach (object current in Enum.GetValues(enumType))
            {
                Enum e = (Enum)current;
                dictionary.Add(e.GetEnumDescription(), current.ToString());
            }
            return dictionary;
        }

        /// <summary>将含有描述信息的枚举绑定到字典中</summary>
        /// <param name="enumType">枚举类型</param>
        /// <returns>枚举绑定到字典</returns>
        public static Dictionary<string, int> GetEnumKeyInt(Type enumType)
        {
            Dictionary<string, int> dictionary = new Dictionary<string, int>();
            foreach (object current in Enum.GetValues(enumType))
            {
                Enum e = (Enum)current;
                try
                {
                    dictionary.Add(e.GetEnumDescription(), Convert.ToInt32(current));
                }
                catch (Exception)
                {
                    dictionary.Add(e.GetEnumDescription(), 0);
                }
            }
            return dictionary;
        }

        /// <summary>将含有描述信息的枚举组装datatable(Table两个字段，Text是描述，Value是值(默认是int的值))</summary>
        /// <param name="enumType">枚举类型</param>
        /// <returns>组装后的datatable</returns>
        public static DataTable GetEnumTable(Type enumType)
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Text");
            dataTable.Columns.Add("Value");
            DataTable result;
            try
            {
                foreach (object current in Enum.GetValues(enumType))
                {
                    DataRow dataRow = dataTable.NewRow();
                    Enum e = (Enum)current;
                    dataRow["Text"] = e.GetEnumDescription();
                    dataRow["Value"] = Convert.ToInt32(current).ToString();
                    dataTable.Rows.Add(dataRow);
                }
            }
            catch (Exception)
            {
                result = null;
                return result;
            }
            result = dataTable;
            return result;
        }
    }
}

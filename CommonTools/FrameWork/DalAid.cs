using CommonTools.Enum;
using CommonTools.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Text.RegularExpressions;

namespace CommonTools.FrameWork
{
    public static class DalAid
    {
        static readonly Regex SqlFromRegex = new Regex(@"\Wfrom\W", RegexOptions.Compiled | RegexOptions.IgnoreCase);//sql语句里的from
        static readonly Regex SqlPreludeRegex = new Regex(@"\w+\.", RegexOptions.Compiled | RegexOptions.IgnoreCase);//sql语句里的前缀

        /// <summary>
        /// 获取分页sql
        /// </summary>
        /// <param name="mailSql"></param>
        /// <param name="dp"></param>
        /// <returns></returns>
        public static Tuple<string, Dictionary<string, object>> GetPageSql(string mailSql, DataPage dp = null)
        {
            string pageSql = "";
            mailSql = mailSql.TrimStart();

            Dictionary<string, object> pars = new Dictionary<string, object>();
            if (dp == null || dp.PageSize == 0) return new Tuple<string, Dictionary<string, object>>(mailSql, pars);
            int fromIndex = SqlFromRegex.Match(mailSql).Index;
            if (fromIndex > 0)
            {
                string fieldSql = mailSql.Substring(0, fromIndex + 5);
                string whereSql = mailSql.Substring(fromIndex + 5);
                // "declare @rowCount int;"
                pageSql = "select @rowCount=count(1) from " + whereSql + ";"
                          + "select @rowCount;if(@PageIndex*@PageSize>@rowCount)set @PageIndex=@rowCount/@PageSize+1;"
                          + SqlPreludeRegex.Replace(fieldSql, "") + "(select ROW_NUMBER() over(order by " + dp.OrderField + ") as RowID,"
                          + fieldSql.Substring(6) + whereSql
                          + ") tempT where RowID BETWEEN (@PageIndex - 1) * @PageSize+1 AND @PageIndex * @PageSize ;";
            }
            pars.Add("@" + DataPage.PageSizeField, dp.PageSize);
            pars.Add("@" + DataPage.PageIndexField, dp.PageIndex);
            return new Tuple<string, Dictionary<string, object>>(pageSql, pars);
        }

        /// <summary>
        /// 分页
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="dp"></param>
        /// <returns></returns>
        public static string CreatePageQuerySqlByMySql(string sql, DataPage dp = null)
        {
            string result = sql;
            if (dp != null && string.IsNullOrEmpty(dp.OrderField) == false)
            {
                result = result + " order by " + dp.OrderField;
            }
            if (dp != null && dp.PageSize > 0)
            {
                int num = (dp.PageIndex - 1) * dp.PageSize;
                result += string.Format(" limit {0},{1} ", num, dp.PageSize);
            }
            return result;
        }

        /// <summary>
        /// dataReader to DataSet
        /// </summary>
        /// <param name="reader"></param>
        /// <returns></returns>
        public static DataSet ToDataSet(this IDataReader reader)
        {
            DataSet dataSet = new DataSet();
            do
            {
                DataTable schemaTable = reader.GetSchemaTable();
                DataTable dataTable = new DataTable();
                Dictionary<string, int> dictionary = new Dictionary<string, int>();
                bool flag = schemaTable != null;
                if (flag)
                {
                    for (int i = 0; i < schemaTable.Rows.Count; i++)
                    {
                        DataRow dataRow = schemaTable.Rows[i];
                        string text = (string)dataRow["ColumnName"];
                        bool flag2 = !dictionary.ContainsKey(text);
                        if (flag2)
                        {
                            dictionary.Add(text, 0);
                        }
                        else
                        {
                            int value = dictionary[text] + 1;
                            dictionary[text] = value;
                            text += value.ToString();
                        }
                        DataColumn column = new DataColumn(text, (Type)dataRow["DataType"]);
                        dataTable.Columns.Add(column);
                    }
                    dataSet.Tables.Add(dataTable);
                    while (reader.Read())
                    {
                        DataRow dataRow2 = dataTable.NewRow();
                        for (int j = 0; j < reader.FieldCount; j++)
                        {
                            dataRow2[j] = reader.GetValue(j);
                        }
                        dataTable.Rows.Add(dataRow2);
                    }
                }
                else
                {
                    DataColumn column2 = new DataColumn("RowsAffected");
                    dataTable.Columns.Add(column2);
                    dataSet.Tables.Add(dataTable);
                    DataRow dataRow3 = dataTable.NewRow();
                    dataRow3[0] = reader.RecordsAffected;
                    dataTable.Rows.Add(dataRow3);
                }
            }
            while (reader.NextResult());
            return dataSet;
        }

        /// <summary>
        /// 创建分页查询条件
        /// </summary>
        /// <param name="sql">sql</param>
        /// <param name="dp">分页</param>
        /// <param name="DBType">数据库类型</param>
        /// <returns>结果</returns>
        public static string CreatePageQuerySql(string sql, DataPage dp, DBType DBType)
        {
            int num = (dp.PageIndex - 1) * dp.PageSize;
            bool flag = DBType == DBType.SQLSERVER;
            if (flag)
            {
                string format = "select *,ROW_NUMBER() OVER(ORDER BY " + dp.OrderField + ") rn from ({0}) a ";
                sql = string.Format(format, sql);
                sql = string.Concat(new object[]
                {
            "SELECT TOP ",
            dp.PageSize,
            " * FROM (",
            sql,
            ") query WHERE rn > ",
            num,
            " ORDER BY rn"
                });
            }
            else
            {
                bool flag2 = string.IsNullOrEmpty(dp.OrderField);
                if (flag2)
                {
                    sql += string.Format(" limit {0},{1} ", num, dp.PageSize);
                }
                else
                {
                    sql = sql + " order by " + dp.OrderField + string.Format(" limit {0},{1} ", num, dp.PageSize);
                }
            }
            return sql;
        }
    }
}

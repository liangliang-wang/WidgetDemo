using CommonTools.Enum;
using CommonTools.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace CommonTools.FrameWork
{
    /// <summary>
    /// 实体查询框架
    /// </summary>
    /// <typeparam name="T">类型T</typeparam>
    public class EntityFrameWork<T> where T : class, new()
    {
        private DBType dbType;

        private Dictionary<DBType, Func<string, string, Dictionary<string, object>, IDbCommand>> commandDic = new Dictionary<DBType, Func<string, string, Dictionary<string, object>, IDbCommand>>();

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="dbType"></param>
        public EntityFrameWork(DBType dbType)
        {
            this.dbType = dbType;
            commandDic.Add(DBType.MYSQL, GetMySqlCommand);
            commandDic.Add(DBType.SQLSERVER, GetMSSqlCommand);
        }

        /// <summary>
        /// 查询单个实体
        /// </summary>
        /// <param name="item">框架实体</param>
        /// <param name="dbConnectionString">数据库链接字符串</param>
        /// <returns>单个对象</returns>
        public T SelectModel(FrameWorkItem item, string dbConnectionString)
        {
            IDataReader dr = null;
            try
            {
                dr = BuildDataReader(item, dbConnectionString);
                if (dr != null && dr.Read())
                {
                    return DynamicBuilderEntity<T>.CreateBuilder(dr).Build(dr);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (dr != null)
                    dr.Close();
            }
            return default(T);
        }

        /// <summary>
        /// 查询集合，带分页
        /// </summary>
        /// <param name="item">框架实体</param>
        /// <param name="dbConnectionString">数据库连接实体</param>
        /// <param name="dp">分页对象</param>
        /// <returns>对象集合</returns>
        public List<T> SelectList(FrameWorkItem item, string dbConnectionString, DataPage dp = null)
        {
            IDataReader dr = null;
            try
            {
                dr = BuildDataReader(item, dbConnectionString, dp);

                List<T> list = new List<T>();
                if (dp != null && dp.PageSize > 0)
                {
                    int result = GetResult<int>(string.Format("SELECT COUNT(1) FROM ({0}) a", item.Sql), dbConnectionString, item.SqlParam);
                    dp.RowCount = result;
                }
                while (dr != null && dr.Read())
                {
                    T tempT = new T();
                    tempT = DynamicBuilderEntity<T>.CreateBuilder(dr).Build(dr);
                    list.Add(tempT);
                }
                return list;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (dr != null)
                    dr.Close();
            }
        }

        /// <summary>
        /// 查询表格数据
        /// </summary>
        /// <param name="item">框架实体</param>
        /// <param name="dbConnectionString">数据库连接实体</param>
        /// <param name="dp">分页对象</param>
        /// <returns></returns>
        public DataTable SelectDataTable(FrameWorkItem item, string dbConnectionString, DataPage dp = null)
        {
            IDataReader dr = null;
            DataTable result = new DataTable();
            try
            {
                dr = BuildDataReader(item, dbConnectionString, dp);
                var datasSet = dr.ToDataSet();
                if (datasSet.Tables.Count > 0)
                {
                    result = datasSet.Tables[0];
                }
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (dr != null)
                    dr.Close();
            }
        }


        /// <summary>
        /// 根据框架实体，条件式的选用sqlhelper
        /// </summary>
        /// <param name="item">框架实体</param>
        /// <param name="dbConnectionString">链接字符串</param>
        /// <param name="dp">分页</param>
        /// <returns>IDataReader</returns>
        private IDataReader BuildDataReader(FrameWorkItem item, string dbConnectionString, DataPage dp = null)
        {
            var sql = DalAid.CreatePageQuerySqlByMySql(item.Sql, dp);
            var connection = new MySqlConnection(dbConnectionString);
            var cmd = new MySqlCommand(sql, connection);
            foreach (var par in item.SqlParam)
                cmd.Parameters.AddWithValue(par.Key, par.Value);
            if (connection.State != ConnectionState.Open)
                connection.Open();
            var cnt = cmd.ExecuteReader();
            return cnt;
        }

        /// <summary>
        /// 获取单结果值
        /// </summary>
        /// <typeparam name="T">泛型</typeparam>
        /// <param name="sql">SQL</param>
        /// <param name="dBConnectionString">数据库链接字符串</param>
        /// <param name="para">查询参数</param>
        /// <returns>结果</returns>
        public T GetResult<T>(string sql, string dBConnectionString, Dictionary<string, object> para)
        {
            T result;
            try
            {
                DataSet dataSet = ExecuteQuery(sql, dBConnectionString, para);
                bool flag2 = dataSet.Tables.Count == 0;
                if (flag2)
                {
                    result = default(T);
                }
                else
                {
                    bool flag3 = dataSet.Tables[0].Rows.Count == 0;
                    if (flag3)
                    {
                        result = default(T);
                    }
                    else
                    {
                        object value = dataSet.Tables[0].Rows[0][0];
                        result = (T)((object)Convert.ChangeType(value, typeof(T)));
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + "\r\n" + sql);
            }
            return result;
        }

        /// <summary>
        /// 执行查询
        /// </summary>
        /// <param name="sql">sql</param>
        /// <param name="dBConnectionString">数据库链接字符串</param>
        /// <param name="cmdParms">参数</param>
        /// <returns>结果</returns>
        public DataSet ExecuteQuery(string sql, string dBConnectionString, Dictionary<string, object> cmdParms)
        {
            DataSet dataSet = new DataSet();
            try
            {
                using (var cmd = GetCommand(sql, dBConnectionString, cmdParms))
                {
                    if (cmd != null)
                    {
                        using (IDataReader dataReader = cmd.ExecuteReader())
                        {
                            dataSet = dataReader.ToDataSet();
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + "\r\n" + sql);
            }
            return dataSet;
        }

        /// <summary>
        /// 获取数据库cmd
        /// </summary>
        /// <param name="sql">sql</param>
        /// <param name="dbConnectionString">数据库连接</param>
        /// <param name="cmdParms">参数</param>
        /// <returns>IDbCommand</returns>
        private IDbCommand GetCommand(string sql, string dbConnectionString, Dictionary<string, object> cmdParms)
        {
            if (commandDic.ContainsKey(dbType))
            {
                return commandDic[dbType](sql, dbConnectionString, cmdParms);
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// 获取mysql的cmd
        /// </summary>
        /// <param name="sql">sql</param>
        /// <param name="dbConnectionString">链接字符串</param>
        /// <param name="cmdParms">参数</param>
        /// <returns>结果</returns>
        private MySqlCommand GetMySqlCommand(string sql, string dbConnectionString, Dictionary<string, object> cmdParms)
        {
            var connection = new MySqlConnection(dbConnectionString);
            var cmd = new MySqlCommand(sql, connection);
            if (cmdParms != null)
            {
                foreach (var item in cmdParms)
                {
                    cmd.Parameters.AddWithValue(item.Key, item.Value);
                }
            }
            return cmd;
        }

        /// <summary>
        /// 获取sqlservice的cmd
        /// </summary>
        /// <param name="sql">sql</param>
        /// <param name="dbConnectionString">链接字符串</param>
        /// <param name="cmdParms">参数</param>
        /// <returns>结果</returns>
        private SqlCommand GetMSSqlCommand(string sql, string dbConnectionString, Dictionary<string, object> cmdParms)
        {
            SqlConnection con = new SqlConnection(dbConnectionString);
            var cmd = new SqlCommand(sql, con);
            if (cmdParms != null)
            {
                foreach (var item in cmdParms)
                {
                    cmd.Parameters.AddWithValue(item.Key, item.Value);
                }
            }
            return cmd;
        }
    }
}

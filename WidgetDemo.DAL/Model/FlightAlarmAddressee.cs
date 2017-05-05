using System;
using System.Collections.Generic;
using System.Data;

namespace WidgetDemo.Entity.Model
{
	///<summary>报警收件人表。</summary>
	public class FlightAlarmAddressee
	{
		#region  FlightAlarmAddressee表元信息
		public const string dbName = "TCFlightMonitor";//库名
		public const string tableName = "FlightAlarmAddressee";//表名
		public const string pkName = "FAAId";//主键名
		public const string insertSql = @"Insert Into " + dbName + ".dbo.FlightAlarmAddressee (FAAName,FAAEmployeeId,FAARowStatus,FAACreateTime,FAAEmail,FAAMobile,FAADeptId,FAARole)values(@FAAName,@FAAEmployeeId,@FAARowStatus,@FAACreateTime,@FAAEmail,@FAAMobile,@FAADeptId,@FAARole);";
		public const string selectSql = @"select FAAId,FAAName,FAAEmployeeId,FAARowStatus,FAACreateTime,FAAEmail,FAAMobile,FAADeptId,FAARole from " + dbName + ".dbo.FlightAlarmAddressee with(nolock) where 1 = 1 ";
		public const string deleteSql = @"delete from  " + dbName + ".dbo.FlightAlarmAddressee where FAAId = @FAAId;";
		public static readonly Dictionary<string,Type> fieldNames;//字段
		public static readonly Dictionary<string, string> fieldNotes;//字备注
		static FlightAlarmAddressee()
		{
		   fieldNames = new Dictionary<string,Type> {{ "FAAId", typeof(int) },{ "FAAName", typeof(string) },{ "FAAEmployeeId", typeof(int) },{ "FAARowStatus", typeof(byte) },{ "FAACreateTime", typeof(DateTime) },{ "FAAEmail", typeof(string) },{ "FAAMobile", typeof(string) },{ "FAADeptId", typeof(string) },{ "FAARole", typeof(string) }};
		   fieldNotes = new Dictionary<string,string> {{ "FAAId", "主键"},{ "FAAName", "收件人姓名"},{ "FAAEmployeeId", "收件人工号"},{ "FAARowStatus", "状态"},{ "FAACreateTime", "创建时间"},{ "FAAEmail", "收件人邮箱"},{ "FAAMobile", "收件人手机号码"},{ "FAADeptId", "所属部门Id"},{ "FAARole", "角色"}};
		}
		/// <summary>库名</summary>
		public string GetDbName() { return dbName;}
		/// <summary>表名</summary>
		public string GetTableName() { return tableName;}
		/// <summary>主键名</summary>
		public string GetPkName() { return pkName;}
		/// <summary>插入Sql</summary>
		public string GetInsertSql(){return insertSql;}
		/// <summary>查询Sql</summary>
		public string GetSelectSql(){return selectSql;}
		/// <summary>删除Sql</summary>
		public string GetDeleteSql(){return deleteSql;}
		/// <summary>字段名集合</summary>
		public Dictionary<string,Type> GetFieldNames() { return fieldNames;}
		/// <summary>字段名集合</summary>
		public Dictionary<string,string> GetFieldNotes() { return fieldNotes;}
		#endregion
		#region  FlightAlarmAddressee默认值
		public FlightAlarmAddressee()
		{
			SetDefaultValue();
		}
		public void SetDefaultValue()
		{
			if (FAAName == null)FAAName = "";
			if (FAACreateTime.Year<1900)FAACreateTime = new DateTime(1900,1,1);
			if (FAAEmail == null)FAAEmail = "";
			if (FAAMobile == null)FAAMobile = "";
			if (FAADeptId == null)FAADeptId = "";
			if (FAARole == null)FAARole = "";
		}
		#endregion
		#region  FlightAlarmAddressee属性9
		///<summary>主键，自增长,int4</summary>
		public int FAAId{ get; set; }
		///<summary>收件人姓名,string100</summary>
		public string FAAName{ get; set; }
		///<summary>收件人工号,int4</summary>
		public int FAAEmployeeId{ get; set; }
		///<summary>状态。0-无效，1-有效。,byte1</summary>
		public byte FAARowStatus{ get; set; }
		///<summary>创建时间,DateTime8</summary>
		public DateTime FAACreateTime{ get; set; }
		///<summary>收件人邮箱，多个用英文｛分号｝隔开,string200</summary>
		public string FAAEmail{ get; set; }
		///<summary>收件人手机号码，最多支持2个，用英文逗号隔开。,string70</summary>
		public string FAAMobile{ get; set; }
		///<summary>所属部门Id,string40</summary>
		public string FAADeptId{ get; set; }
		///<summary>角色,string60</summary>
		public string FAARole{ get; set; }
		#endregion
		/// <summary>主键int</summary>
		public object PkValue { get { return FAAId; } set { if (value is int)FAAId = (int)value; } } 
		/// <summary>得到主键集合</summary>
		public Dictionary<string, object> GetPkValues()
		{
		    Dictionary<string, object> pkValues = new Dictionary<string, object>();
		    pkValues.Add("FAAId", FAAId);
		    return pkValues;
		}
		///<summary>IDataRecord填充实体,返回自己</summary>
		///<param name="colName">列名的列次序，可调用GetColNameIndex获得</param>
		public FlightAlarmAddressee BuildEntity(IDataRecord dataRecord,Dictionary<string,int> colName)
		{
			if (colName.ContainsKey("FAAId"))FAAId =dataRecord.GetInt32(colName["FAAId"]);
			if (colName.ContainsKey("FAAName"))FAAName =dataRecord.GetString(colName["FAAName"]);
			if (colName.ContainsKey("FAAEmployeeId"))FAAEmployeeId =dataRecord.GetInt32(colName["FAAEmployeeId"]);
			if (colName.ContainsKey("FAARowStatus"))FAARowStatus =dataRecord.GetByte(colName["FAARowStatus"]);
			if (colName.ContainsKey("FAACreateTime"))FAACreateTime =dataRecord.GetDateTime(colName["FAACreateTime"]);
			if (colName.ContainsKey("FAAEmail"))FAAEmail =dataRecord.GetString(colName["FAAEmail"]);
			if (colName.ContainsKey("FAAMobile"))FAAMobile =dataRecord.GetString(colName["FAAMobile"]);
			if (colName.ContainsKey("FAADeptId"))FAADeptId =dataRecord.GetString(colName["FAADeptId"]);
			if (colName.ContainsKey("FAARole"))FAARole =dataRecord.GetString(colName["FAARole"]);
			return this;
		}
		///<summary>DataRow填充实体,返回自己</summary>
		///<param name="colName">列名的列次序，可调用GetColNameIndex获得</param>
		public FlightAlarmAddressee BuildEntity(DataRow dr, Dictionary<string, int> colName)
		{
			if (colName.ContainsKey("FAAId"))FAAId =(Int32)dr[colName["FAAId"]];
			if (colName.ContainsKey("FAAName"))FAAName =(String)dr[colName["FAAName"]];
			if (colName.ContainsKey("FAAEmployeeId"))FAAEmployeeId =(Int32)dr[colName["FAAEmployeeId"]];
			if (colName.ContainsKey("FAARowStatus"))FAARowStatus =(Byte)dr[colName["FAARowStatus"]];
			if (colName.ContainsKey("FAACreateTime"))FAACreateTime =(DateTime)dr[colName["FAACreateTime"]];
			if (colName.ContainsKey("FAAEmail"))FAAEmail =(String)dr[colName["FAAEmail"]];
			if (colName.ContainsKey("FAAMobile"))FAAMobile =(String)dr[colName["FAAMobile"]];
			if (colName.ContainsKey("FAADeptId"))FAADeptId =(String)dr[colName["FAADeptId"]];
			if (colName.ContainsKey("FAARole"))FAARole =(String)dr[colName["FAARole"]];
			return this;
		}
		///<summary>返回对象Josn字串</summary>
		public string ToJosn()
		{
			return "{\"TableName\":\"FlightAlarmAddressee\""
				+",\"FAAId\":\""+FAAId+"\""
				+",\"FAAName\":\""+FAAName+"\""
				+",\"FAAEmployeeId\":\""+FAAEmployeeId+"\""
				+",\"FAARowStatus\":\""+FAARowStatus+"\""
				+",\"FAACreateTime\":\""+FAACreateTime+"\""
				+",\"FAAEmail\":\""+FAAEmail+"\""
				+",\"FAAMobile\":\""+FAAMobile+"\""
				+",\"FAADeptId\":\""+FAADeptId+"\""
				+",\"FAARole\":\""+FAARole+"\""
				+"}";
		}
	}
}

